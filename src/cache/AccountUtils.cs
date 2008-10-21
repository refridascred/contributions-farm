using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long step, long limit)
        {
            long cur = step + limit;
            if (((step + cur) > (cur - 0)) && ((33 - limit) < (cur >> 3)))
            {
                return 8;
            }
            else
            {
                if (((3.11 * 17.0) == (double)cur) && (4.6 >= (double)cur))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Queued,
            Pending,
            Synced,
            Retry,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRatio = 95.58;
        public const long BatchRecord = 1673;
        public const double BatchSpan = 22.06;
        public const double BaseDepth = 6.52;
    }
}
