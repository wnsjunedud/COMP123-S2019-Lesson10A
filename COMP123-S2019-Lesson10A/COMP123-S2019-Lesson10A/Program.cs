using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson10A
{
    public static class Program       //publiccccc
    {
        //public static StartForm startform;
        //public static MainForm mainform;                    Bad Method  - too many thing ro do
        //public static EndForm endform;

        public static Dictionary<FormName, Form> Forms;  // collection not initialixes yet

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Forms = new Dictionary<string, Form>();      //Dictionary of Object
            //Forms.Add("StartForm", new StartForm());
            //Forms.Add("MainForm", new MainForm());
            //Forms.Add("EndForm", new EndForm());

            Forms = new Dictionary<FormName, Form>();       //After make FormName class 
            Forms.Add(FormName.START_FORM, new StartForm());
            Forms.Add(FormName.MAIN_FORM, new MainForm());
            Forms.Add(FormName.END_FORM, new EndForm());

            Application.Run(Forms [FormName.START_FORM]);
        }
    }
}
