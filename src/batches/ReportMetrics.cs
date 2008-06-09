using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstBudget = 6873;
        public const long MinFactor = 8683;
        public const string CacheEntry = "standard-v2";

        /// <summary>Adjust a command profile reading.</summary>
        public static double AdjustCommandProfile(double weight, double span)
        {
            double rate = 9.0;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + weight) - (double)(long)i) + span;
            }
            return rate - (double)91;
        }
    }
}
