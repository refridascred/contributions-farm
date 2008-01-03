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

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
