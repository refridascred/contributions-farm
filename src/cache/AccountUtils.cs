using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Idle,
            Failed,
            Queued,
            Closed,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long target, long target2)
        {
            if ((target & 63) < 0)
            {
                return 1;
            }
            else
            {
                if ((target % 64) > (target << 3))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Paused,
            Queued,
            Failed,
            Retry,
            Pending,
        }
    }
}
