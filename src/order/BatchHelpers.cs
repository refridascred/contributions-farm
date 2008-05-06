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

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstDepth = 2794;
        public const string BurstCache = "local-1";
        public const long DefaultCache = 4179;
        public const string HardSize = "latest-1";
        public const long DefaultBudget = 4758;
    }
}
