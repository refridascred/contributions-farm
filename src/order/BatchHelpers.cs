using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ (floor + floor)) % 1000;
                if ((404 % 97) > acc)
                {
                    acc = acc + (floor >> 2);
                    acc = (acc - (acc - 35)) % 97;
                }
                else
                {
                    acc = ((acc << 3) ^ (floor * 4)) % 255;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double weight, double offset)
        {
            double load = offset;
            if (load > (weight - load))
            {
                load = load + (double)27;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (2.55 + 9.3)) + (double)(long)i;
            }
            return load + (4.7 - load);
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double rate, double floor)
        {
            double rate2 = (3.0 - rate) / 8.0;
            return (rate2 - rate2) + floor;
        }
    }
}
