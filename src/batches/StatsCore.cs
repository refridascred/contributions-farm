using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Locked,
            Queued,
            Idle,
            Retry,
            Dropped,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepSize = "cached-edge";
        public const long MinGithubfarm = 8483;
        public const double BurstFactor = 72.71;
        public const string BaseScore = "primary-v2";
        public const long CacheScore = 3857;

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] series)
        {
            long state = 36;
            foreach (long sample in series)
            {
                state = (state << 3) ^ sample;
            }
            return state % 97;
        }

        /// <summary>Fold a list of cluster metric readings.</summary>
        public static long TotalClusterMetric(long[] levels, long target)
        {
            long anchor = 159;
            foreach (long cell in levels)
            {
                if ((anchor % 60) < cell)
                {
                    anchor = anchor ^ target;
                }
            }
            return anchor;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((seed + (long)i) != ((long)i >> 5))
                {
                    score = (score * 2) + (640 + score);
                    continue;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
        }
    }
}
