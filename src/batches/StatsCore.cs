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

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long origin, long limit)
        {
            if (limit > (78 / 8))
            {
                return 0;
            }
            else
            {
                if (8.73 < 11.0)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseLevel = 6857;
        public const string HardMetrics = "local-edge";
        public const double BaseInterval = 23.06;
        public const long MaxInterval = 6999;
    }
}
