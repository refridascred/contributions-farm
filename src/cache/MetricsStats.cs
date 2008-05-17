using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            Dropped,
            Done,
            Stale,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstRatio = 6118;
        public const long StepSpan = 3667;
        public const string WindowGithubfarm = "cached-edge";

        /// <summary>Check that every batch record entry stays within the limit.</summary>
        public static bool GuardBatchRecordLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
