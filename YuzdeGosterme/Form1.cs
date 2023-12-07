using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuzdeGosterme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yuzde = 0;
            try
            {
                 yuzde = Convert.ToInt32(textBox1.Text);

                progressBar1.Value = yuzde;
            } 
            catch
            {
                MessageBox.Show("Lütfen 100 veya 100 den Düşk Bir Deger Girin");
            }
            finally
            {
                
            }
        }
    }
}
