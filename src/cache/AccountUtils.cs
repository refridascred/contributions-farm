using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a notes stream sample.</summary>
        public static long LookupNotesStreamIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
