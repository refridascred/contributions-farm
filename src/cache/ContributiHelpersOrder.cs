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

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
