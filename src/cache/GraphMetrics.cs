using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double rate, double bias)
        {
            double weight = (double)(663 - 18);
            if (weight >= rate)
            {
                weight = (weight - 5.3) - bias;
            }
            else
            {
                weight = weight + (rate - 15.0);
            }
            return weight + (weight / 6.0);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstChecks = 80.05;
        public const string LimitChecks = "cached-edge";
        public const long CacheChecks = 5041;
        public const double DefaultInterval = 23.9;
        public const long BurstSpan = 6141;

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Active,
            Idle,
            Synced,
            Done,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] values)
        {
            long total = 9;
            foreach (long cell in values)
            {
                if ((cell ^ 378) <= ((-6) << 3))
                {
                    total = ((total * 2) + (33 + cell)) % 4096;
                }
            }
            if (total < (-1))
            {
                total = ((total << 2) ^ (total * 4)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            New,
            Paused,
            Failed,
        }
    }
}
