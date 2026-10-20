using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace _3N_LIDTS_CARLOSSANCHEZ_07
{
    public partial class Form1 : Form
    {
        public SerialPort ArduinoPort { get;}
        public Form1()
        {
            InitializeComponent();
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM9";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();

            this.FormClosing += CerrandoForm1;
            this.btnEncender.Click += button1_Click;
            this.btnApagar.Click += button2_Click;
        }

        private void CerrandoForm1(object sender, FormClosingEventArgs e)
        {
            if (ArduinoPort.IsOpen)
            {
                ArduinoPort.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("b");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("a");
        }
    }
}
