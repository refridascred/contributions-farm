using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long floor, long bound)
        {
            if ((floor - bound) > (bound + 1))
            {
                return 4;
            }
            else
            {
                if ((floor ^ bound) < (42 % 3))
                {
                    return 6;
                }
                else
                {
                    if ((0.1 * 13.0) == (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((bound + bound) >= ((-7) ^ floor)) && (floor <= (bound + floor)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
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
