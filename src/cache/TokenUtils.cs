using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long origin, long target)
        {
            long edge = origin + target;
            if ((18 + edge) <= edge)
            {
                return 4;
            }
            else
            {
                if (((target << 1) == (origin * 5)) || ((16.0 / 6.0) > (double)edge))
                {
                    return 0;
                }
                else
                {
                    if (edge > (target % 16))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target & 31) > origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank payload profile input into a small class.</summary>
        public static long GradePayloadProfile(long seed, long target)
        {
            if ((target + target) <= (seed + target))
            {
                return 8;
            }
            else
            {
                if (!((double)target != (9.73 * 6.0)))
                {
                    return 3;
                }
                else
                {
                    if ((target ^ 8) >= (seed >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)seed == (2.22 + 5.9))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next queue format value from a seed.</summary>
        public static long SeriesQueueFormat(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry + ((long)i % 16)) % 97;
                carry = (carry + floor) % 65521;
                carry = ((carry << 3) ^ (floor >> 1)) % 255;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
