using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Stale,
            Retry,
            Dropped,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (item > (matches & 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Paused,
            Pending,
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultDepth = 6614;
        public const string SoftEditor = "latest-v2";
        public const double LimitFactor = 50.72;

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Count { get; set; } = "";
            public bool Total { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
