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

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 1)
                    {
                        hits = hits + 1;
                    }
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
