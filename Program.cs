using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Class.NewCsharpClass;

namespace PracticesForTheExam
{
    class Program
    {
        // while
        // if
        // for
        // data types > int decimal char string bool datetime
        // cast > int.tryParse()
        // Arrays
        static void Main(string[] args)
        {
            // Test your methods here
            // Calling solution 1
            //getGreatestValue();

            // Call solution 2
            //getSomething();
            //yayayyaya

            //MismoDiaExamen();
            NewCsharpClass();


            // Makes the console wait for input
            Console.ReadKey();
        }

        private static void getSomething()
        {
            // implement your next solution
        }

        // Implement problems 1 by 1
        // each problem must be one method

        // 1 Implement a method that prompts the user to input three integer values 
        // and find the greatest value of the three values.
        public static int getGreatestValue()
        {
            int greatestVal = 0;

            Console.WriteLine("Enter value 1");
            int val1 = 0;
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out val1);
            Console.WriteLine("");

            Console.WriteLine("Enter value 2");
            int val2 = 0;
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out val2);
            Console.WriteLine("");

            Console.WriteLine("Enter value 3");
            int val3 = 0;
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out val3);
            Console.WriteLine("");

            int[] arrTemp = new int[3];
            arrTemp[0] = val1;
            arrTemp[1] = val2;
            arrTemp[2] = val3;

            Array.Sort(arrTemp);

            Console.WriteLine(arrTemp[2].ToString());


            // processing goes here
            // if - else
            // array?
            if (val1 > val2)
                if (val3 > val1)
                    greatestVal = val3;
                else
                    greatestVal = val1;
            else
            {
                if (val3 > val2)
                    greatestVal = val3;
                else
                    greatestVal = val2;
            }

            Console.WriteLine("Greatest value is " + greatestVal.ToString());

            return greatestVal;
        }

        public static void MismoDiaExamen()
        {

            int[] newNameOfAnArray = new int[50];
            double[] NNOAA2 = {1.0,2.02};
            DateTime[] NNOAA3 = DateTime[20];



            int variableProvisional1 = 1;
            Console.WriteLine("mete un string de lo que sea: ");
            int EnteredSentence;
            if (int.TryParse(Console.ReadLine(), out EnteredSentence))
                Console.WriteLine("correcto!");
            else Console.WriteLine("error en el TryParse");

            Console.WriteLine("Now I print the sentenced just entered:   " + EnteredSentence.ToString());

            while (variableProvisional1 < 100)
            {
                Console.WriteLine("Vamos contando por... " + variableProvisional1);
                Console.WriteLine("Siendo ahorita mismo la hora.min.seg.miliseg del dia:  " + DateTime.Now.ToString("hh.mm.ss.ff"));
                if (DateTime.Now.ToString("hh") == "02")
                {
                    Console.WriteLine("En este caso son las 2. Hora de comer. Seguiré a partir de las 3. Ahora Paro");
                    Console.WriteLine("Imprimo el caracter ASCII de esta hora    " + (char)variableProvisional1);
                    break;
                }
                else continue;
                variableProvisional1++;
            }
        }

    }
}
