using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double bias, double floor)
        {
            double weight = (double)0 / 5.0;
            if (weight <= (bias + weight))
            {
                weight = weight + (weight / 6.0);
            }
            else
            {
                weight = weight - 8.79;
            }
            return weight - floor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardTimeout = 7676;
        public const long BaseFilter = 4699;
        public const long BurstFilter = 5072;
        public const string MinRatio = "alpha-edge";
        public const double MaxDepth = 98.74;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
