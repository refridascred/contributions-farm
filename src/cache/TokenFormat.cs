using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a layout command reading by value.</summary>
        public static long LookupLayoutCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 1759;
        public const double IdleRecord = 60.05;
        public const double MinWidth = 73.31;
        public const long BurstDepth = 8501;

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double rate, double bias)
        {
            double rate2 = (double)(309 / 4);
            if (rate2 > bias)
            {
                rate2 = (rate2 + rate2) + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + (rate2 * 5.0)) + (double)(long)i;
            }
            return rate2 + rate2;
        }
    }
}
