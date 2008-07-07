using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long target, long step)
        {
            if ((target + step) <= (step >> 1))
            {
                return 0;
            }
            else
            {
                if ((target & 31) != (target << 3))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Retry,
            Queued,
            Closed,
            Dropped,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinSize = 487;
        public const string BaseContext = "fallback-edge";
        public const long CacheContext = 5723;
        public const long RetryContext = 8211;
    }
}
