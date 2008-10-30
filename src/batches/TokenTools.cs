using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Done,
            Failed,
            Stale,
            Queued,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long target, long step)
        {
            if (((double)step >= (2.3 * 8.0)) || ((target / 9) == (step - step)))
            {
                return 4;
            }
            else
            {
                if (step > (target + target))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitScore = 187;
        public const long RetrySession = 7471;
        public const long RetryLevel = 5071;
    }
}
