using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] values, long bound)
        {
            long anchor = 784;
            foreach (long item in values)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) - item;
                if ((anchor - anchor) < bound)
                {
                    anchor = anchor + bound;
                }
            }
            return anchor;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Score { get; set; }
            public double Count { get; set; }
            public double Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            New,
            Idle,
            Retry,
            Closed,
        }
    }
}
