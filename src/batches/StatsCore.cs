using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] data)
        {
            long sum = 7;
            foreach (long cell in data)
            {
                sum = (sum + (sum & 127)) + cell;
            }
            return sum % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxInterval = "alpha-1";
        public const string LimitCount = "primary-edge";
        public const string MinCluster = "alpha-edge";
        public const string HardLevel = "open-edge";
        public const long RetryRatio = 9259;

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseSupport = 89.56;
        public const double SoftFactor = 86.9;
        public const long MaxLevel = 1547;
        public const double WindowInterval = 92.74;
        public const double MaxSupport = 18.63;

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 3304;
        public const double DefaultInterval = 54.66;
        public const string BurstRatio = "standard";

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(((long)samples.Length % 12) <= tally))
                {
                    tally = ((tally + 1) + value) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
