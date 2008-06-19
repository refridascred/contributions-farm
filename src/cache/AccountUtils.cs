using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Dropped,
            Ready,
            Idle,
            New,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long seed, long seed2)
        {
            if ((double)seed > (6.0 + 11.0))
            {
                return 5;
            }
            else
            {
                if ((seed2 & 7) >= seed2)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Done,
            Ready,
            Queued,
        }
    }
}
