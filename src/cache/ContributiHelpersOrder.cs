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

        /// <summary>Audit channel checks readings against a rule.</summary>
        public static long CountChannelChecksGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum + datum) >= (count >> 3))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
