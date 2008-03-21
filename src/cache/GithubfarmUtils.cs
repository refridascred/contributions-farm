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

        /// <summary>Combine channel metrics values into a single score.</summary>
        public static long DigestChannelMetrics(long[] levels)
        {
            long mix = -1;
            foreach (long cell in levels)
            {
                if (((1.78 / 9.0) < (double)cell) || (mix >= (mix / 6)))
                {
                    mix = (mix - (mix - cell)) % 4096;
                }
                if ((78 >> 2) <= (cell << 1))
                {
                    mix = (mix ^ (87 / 6)) % 1000;
                }
                else
                {
                    mix = mix - cell;
                }
            }
            if (mix > 579)
            {
                mix = (mix - (mix + mix)) % 255;
            }
            return mix;
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
