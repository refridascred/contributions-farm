using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long seed, long floor)
        {
            long step = seed ^ floor;
            if ((floor * 4) == (floor ^ floor))
            {
                return 4;
            }
            else
            {
                if (((double)step >= (double)seed) || (seed > (step >> 5)))
                {
                    return 1;
                }
                else
                {
                    if (((seed % 3) != (floor + 89)) || ((seed & 255) >= (step << 1)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed << 1) <= step)
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
        }

        /// <summary>Find the first cache githubfarm entry that matches the target.</summary>
        public static long LookupCacheGithubfarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long limit, long step)
        {
            if (((1.64 * 2.8) >= (1.21 - 11.0)) || (step >= (89 ^ limit)))
            {
                return 8;
            }
            else
            {
                if (((step * 4) <= (limit >> 1)) || ((6.81 - 6.16) != (double)step))
                {
                    return 0;
                }
                else
                {
                    if ((limit % 12) < (80 + step))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit < (step << 2)) || (step <= (step ^ 255)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long offset, long seed)
        {
            long bound = offset + seed;
            if (((double)bound < (7.6 - 8.4)) || ((offset >> 2) != (seed / 4)))
            {
                return 6;
            }
            else
            {
                if (offset >= (bound ^ offset))
                {
                    return 4;
                }
                else
                {
                    if ((-457) <= (seed - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset + offset) == (bound + bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
