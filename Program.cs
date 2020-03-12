using System;

namespace Version25
{
    class Program
    {


        static void Main(string[] args)
        {
            
            Console.WriteLine("Name: Sofia Chumpitazi" + "  Version = 25");

            // enter any string characters
            Console.WriteLine("Enter any strings of characters");
            string userinput = Console.ReadLine();

            // enter number 2-5
            Console.WriteLine("Enter any numbers between 2 to 5");
            string number = Console.ReadLine();
            int valueofnumber = int.Parse(number);

            // enter single character
            Console.Write("Enter a single character only");

            string special = Console.ReadLine();
            

            MethodNumbers(userinput, valueofnumber, special);
         
        }


        static void MethodNumbers(string msg, int num, string sep)
        {

            Console.WriteLine("User Message = " + msg);
            Console.WriteLine("User Number = " + num);
            Console.WriteLine("User Separator = " + sep);


            for (int i = 1; i <= num; i++)
            {
                Console.Write(msg + sep);
            }
            

            
        }
       


    }
}
