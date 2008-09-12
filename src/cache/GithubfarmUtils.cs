using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)matches > (3.89 + 8.93))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstRatio = 9737;
        public const string MaxSchema = "alpha-1";
        public const double DefaultSchema = 9.14;
        public const string BaseSchema = "fallback-edge";
        public const long CacheSchema = 2533;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Queued,
            Locked,
            Synced,
            Draft,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] readings)
        {
            long state = -911;
            foreach (long entry in readings)
            {
                state = state ^ (state - entry);
            }
            return state;
        }
    }
}
