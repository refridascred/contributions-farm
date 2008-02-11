using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix << 3) ^ (8 - 38)) % 255;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix + mix) % 1000) ^ (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long limit, long origin)
        {
            if (!((6 % 97) < (origin & 63)))
            {
                return 8;
            }
            else
            {
                if ((origin & 15) != (389 + limit))
                {
                    return 4;
                }
                else
                {
                    if ((limit / 2) > (limit + limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long seed, long seed2)
        {
            long slot = seed - seed2;
            if ((seed2 + slot) >= seed2)
            {
                return 2;
            }
            else
            {
                if (6 >= (seed2 & 7))
                {
                    return 6;
                }
                else
                {
                    if ((8.9 * 8.65) != (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)seed < (6.98 - 5.81))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((seen / 6) == (origin << 1)))
                {
                    seen = (seen + 1) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long origin, long seed)
        {
            if (seed <= (origin - seed))
            {
                return 1;
            }
            else
            {
                if ((origin << 3) > origin)
                {
                    return 5;
                }
                else
                {
                    if (seed <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long origin, long seed)
        {
            long lane = origin - seed;
            if ((lane % 8) <= seed)
            {
                return 0;
            }
            else
            {
                if ((double)(-83) >= (double)lane)
                {
                    return 5;
                }
                else
                {
                    if ((-2) <= (origin + lane))
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
}
