using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long floor, long offset)
        {
            long cur = floor + offset;
            if (!((floor ^ offset) <= (floor ^ floor)))
            {
                return 0;
            }
            else
            {
                if (((-543) - floor) != (offset & 31))
                {
                    return 4;
                }
                else
                {
                    if ((double)956 <= (double)cur)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstBudget = 8593;
        public const string MinFilter = "stable-1";
        public const long IdleFilter = 2423;
        public const double BaseCount = 43.38;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Active,
            Idle,
            Ready,
            Synced,
            Draft,
        }
    }
}
