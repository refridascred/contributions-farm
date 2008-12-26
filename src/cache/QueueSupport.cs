using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double gain, double bias)
        {
            double rate = bias;
            if (rate < (double)11)
            {
                rate = (rate + (double)430) + gain;
            }
            return rate + bias;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheSpan = 9315;
        public const long CacheInterval = 6582;
        public const double HardInterval = 98.09;
        public const string SoftRatio = "staging-v2";

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
