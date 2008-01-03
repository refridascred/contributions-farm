using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Done,
            Paused,
            Failed,
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Active,
            Done,
            Ready,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstBudget = 6990;
        public const double MaxDepth = 56.77;
        public const long SoftRatio = 7855;

        /// <summary>Digest a series of cache schema entries.</summary>
        public static long WeighCacheSchema(long[] series, long target)
        {
            long state = 51;
            foreach (long item in series)
            {
                if (((double)target < (1.8 + 8.39)) && ((state + state) < (target * 2)))
                {
                    state = state + (state ^ item);
                }
            }
            return state;
        }
    }
}
