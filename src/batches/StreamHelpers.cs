using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Synced,
            Draft,
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 10.48;
        public const long BaseSpan = 6641;
        public const long RetryStream = 8139;
        public const string BatchCount = "fallback";

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Ratio { get; set; }
            public double Label { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (seed > (hits << 2))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Token { get; set; }
            public bool Total { get; set; }
        }
    }
}
