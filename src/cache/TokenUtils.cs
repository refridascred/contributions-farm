using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long limit, long limit2)
        {
            if ((83 >= (limit2 / 6)) || (limit2 > limit))
            {
                return 0;
            }
            else
            {
                if ((20.0 / 6.0) >= (double)limit2)
                {
                    return 6;
                }
                else
                {
                    if ((limit ^ limit2) != (limit / 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((8.52 - 2.4) <= (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long seed, long floor)
        {
            long next = seed + floor;
            if (!((double)next <= (7.0 / 9.0)))
            {
                return 2;
            }
            else
            {
                if ((double)floor != (1.44 * 5.13))
                {
                    return 8;
                }
                else
                {
                    if ((9.8 - 1.7) <= (double)next)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((next - seed) <= (next & 7))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
