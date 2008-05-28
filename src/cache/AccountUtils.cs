using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long limit, long target)
        {
            if ((target + limit) >= (target % 24))
            {
                return 4;
            }
            else
            {
                if ((target + 2) == (target & 31))
                {
                    return 1;
                }
                else
                {
                    if ((target / 7) != (target + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long target, long floor)
        {
            long span = target ^ floor;
            if (floor > 90)
            {
                return 4;
            }
            else
            {
                if ((target - floor) > (span >> 3))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
