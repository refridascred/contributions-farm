using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every schema entry entry stays within the limit.</summary>
        public static bool VerifySchemaEntryBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long seed, long offset)
        {
            long next = seed + offset;
            if ((seed >= (offset - offset)) && ((next % 100) >= (seed % 60)))
            {
                return 4;
            }
            else
            {
                if ((2 + seed) < (offset / 2))
                {
                    return 3;
                }
                else
                {
                    if (((next / 9) >= (seed % 97)) || ((seed + seed) <= (497 - seed)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((60 + offset) >= (next - seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                state = state ^ (seed * 2);
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
