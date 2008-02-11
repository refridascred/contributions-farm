using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((double)hits < 3.6) || ((cell << 1) < (cell % 12)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Stale,
            Retry,
            Idle,
            Draft,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (bound > (bound + reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
