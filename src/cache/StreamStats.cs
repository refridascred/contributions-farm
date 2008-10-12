using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)target <= (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Dropped,
            Synced,
            Locked,
            Retry,
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Done,
            Queued,
            Synced,
            Failed,
            New,
        }
    }
}
