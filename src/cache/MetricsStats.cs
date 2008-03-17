using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long seed, long limit)
        {
            if ((double)limit < (9.94 / 5.0))
            {
                return 4;
            }
            else
            {
                if (!((46 - seed) <= (seed * 2)))
                {
                    return 5;
                }
                else
                {
                    if (seed < limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((seed ^ seed) > (seed % 100)))
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

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long floor, long step)
        {
            if ((step + step) == (floor + floor))
            {
                return 3;
            }
            else
            {
                if (!((floor ^ floor) < floor))
                {
                    return 7;
                }
                else
                {
                    if ((double)step > (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank githubfarm channel input into a small class.</summary>
        public static long RankGithubfarmChannel(long origin, long floor)
        {
            if (origin < (floor + (-699)))
            {
                return 0;
            }
            else
            {
                if (!((10.0 * 2.2) == (double)floor))
                {
                    return 8;
                }
                else
                {
                    if ((origin >> 1) > (floor - 357))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
