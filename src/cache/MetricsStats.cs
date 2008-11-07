using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 2175;
        public const string MaxCluster = "legacy";
        public const long LimitSpan = 4212;
        public const long DefaultTimeout = 4965;
        public const double WindowTimeout = 59.05;

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count + item) >= (item ^ 97))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 1576;
        public const string SoftWidth = "legacy";
        public const string IdleMetric = "primary-1";
        public const long DefaultBudget = 5018;
        public const string BurstMetric = "fallback-edge";

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double gain, double floor)
        {
            double drift = (double)((-84) - 4);
            if (drift >= (floor / 7.0))
            {
                drift = (drift - (floor + drift)) - gain;
            }
            return drift + (drift * 3.0);
        }
    }
}
