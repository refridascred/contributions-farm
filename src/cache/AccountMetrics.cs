using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next queue account value.</summary>
        public static double ProjectQueueAccount(double gain, double bias)
        {
            double weight = bias / 8.0;
            if (weight <= (double)2)
            {
                weight = (weight + (double)33) - gain;
            }
            else
            {
                weight = weight - weight;
            }
            return weight + (double)38;
        }

        /// <summary>Audit cache stats readings against a rule.</summary>
        public static long TallyCacheStatsOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value + (long)readings.Length) > (matches % 10))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public bool Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Draft,
            New,
            Synced,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Total { get; set; }
            public double Owner { get; set; }
            public string Ratio { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
