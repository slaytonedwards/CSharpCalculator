using System;

namespace C_SharpCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables and initialize to zero
            int num1 = 0;
            int num2 = 0;

            //Display title as C# calculator app
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            //Ask user to type the first number
            Console.WriteLine("Type a number and press enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            //Ask user to type second number
            Console.WriteLine("Type a second number and press enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Ask user to choose option
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Choice? ");

            //use switch statement to do the math
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            //Wait for user to respond before closing
            Console.Write("Press any key to close Calculator");
            Console.ReadLine();
        }
    } 
}
