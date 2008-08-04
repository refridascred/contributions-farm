using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchBudget = 15.16;
        public const double WindowCounter = 90.54;
        public const long CacheCounter = 5267;
        public const double MinCounter = 6.9;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Failed,
            Pending,
            Stale,
            New,
            Idle,
        }

        /// <summary>Iterate the token payload series from a seed.</summary>
        public static long SeriesTokenPayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry - (-36)) % 97;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long floor, long bound)
        {
            if (!((19.0 + 7.0) > (double)floor))
            {
                return 6;
            }
            else
            {
                if (((double)floor == (14.0 / 5.0)) && (floor <= (bound >> 3)))
                {
                    return 7;
                }
                else
                {
                    if ((bound >> 5) > (floor - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxRecord = 44.32;
        public const double IdleRecord = 24.39;
        public const long LimitWidth = 5434;
    }
}
