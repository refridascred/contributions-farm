using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 8349;
        public const double LimitEntry = 46.49;
        public const long WindowDepth = 7847;
        public const long CacheWidth = 2874;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry <= (origin << 2)) || ((entry - origin) >= (origin - entry)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Rank { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Derive the next metric githubfarm value from a seed.</summary>
        public static long IterateMetricGithubfarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
