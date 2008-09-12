using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Stale,
            Pending,
            Synced,
            Draft,
            Paused,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryWidth = 3837;
        public const long HardCluster = 3550;
        public const double DefaultCluster = 96.94;
        public const long MaxCluster = 9225;

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultSize = 6830;
        public const long BatchRecord = 8092;
        public const double MaxRecord = 50.38;
        public const long IdleRecord = 5940;

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] data, long target)
        {
            long sum = 5;
            foreach (long cell in data)
            {
                if (((-6) ^ target) == (target / 2))
                {
                    sum = ((sum << 3) ^ (9 * 4)) ^ cell;
                }
            }
            return sum;
        }
    }
}
