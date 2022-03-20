using System;

namespace Operator_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var div = a / b;
            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {div} and the remainder is {mod}");

            var r = 20;
            var pi = Math.PI;

            Console.WriteLine("What is the radius?");
            var radius = double.Parse(Console.ReadLine());
            var areaOfCircle = CalculateArea(radius);


            Console.WriteLine($"The area of a circle with a radius of {radius} is {areaOfCircle}.");

        }

        public static double CalculateArea(double radius)
        {
            return Math.PI * (radius * radius);
        }


    }
}