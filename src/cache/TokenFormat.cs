using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long target, long step)
        {
            long slot = target + step;
            if (((target + target) == (slot + 8)) && (step >= (3 + target)))
            {
                return 7;
            }
            else
            {
                if ((double)target <= (double)step)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Pending,
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long offset, long step)
        {
            if ((offset << 1) >= (step - step))
            {
                return 8;
            }
            else
            {
                if ((double)step <= (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
