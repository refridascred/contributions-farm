using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
