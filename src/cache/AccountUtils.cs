using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double gain, double bias)
        {
            double gain2 = 1.0;
            if (gain2 < gain)
            {
                gain2 = (gain2 - 3.1) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 + (double)94;
        }

        /// <summary>Rank cache filter input into a small class.</summary>
        public static long ClassifyCacheFilter(long seed, long origin)
        {
            if (!((double)seed == (9.8 + 0.54)))
            {
                return 2;
            }
            else
            {
                if ((double)seed < (12.0 + 6.6))
                {
                    return 4;
                }
                else
                {
                    if (((seed & 7) < (37 % 5)) || ((origin << 2) >= seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed % 64) <= (origin - seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long target, long target2)
        {
            if ((target - target2) >= target)
            {
                return 7;
            }
            else
            {
                if (((double)target < 14.0) && ((target << 2) >= 9))
                {
                    return 8;
                }
                else
                {
                    if ((double)target2 != (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((double)target <= (double)target2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
