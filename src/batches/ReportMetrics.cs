using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double bias, double floor)
        {
            double weight = (double)(-3);
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + 15.0) - (double)(long)i;
            }
            return weight + (bias - floor);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchChecks = 68.34;
        public const double CacheInterval = 14.24;
        public const double BaseChecks = 38.23;
        public const long BurstChecks = 9122;
    }
}
