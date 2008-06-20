using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank cache context input into a small class.</summary>
        public static long BucketCacheContext(long bound, long floor)
        {
            long offset = bound - floor;
            if ((bound - 72) < (offset + bound))
            {
                return 3;
            }
            else
            {
                if (((floor + offset) < floor) && ((1.0 + 1.06) < (double)offset))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 1800;
        public const string WindowOrder = "fallback-v2";
        public const double HardWidth = 9.41;
        public const double RetryWidth = 45.2;

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Synced,
            Failed,
            Active,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
