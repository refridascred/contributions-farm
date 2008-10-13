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

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
