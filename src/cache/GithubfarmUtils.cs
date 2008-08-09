using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long offset, long step)
        {
            long slot = offset + step;
            if (((offset + step) < offset) || (slot > (offset << 2)))
            {
                return 3;
            }
            else
            {
                if ((step - slot) >= (slot ^ step))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((reading + matches) > (matches - reading)) || (((double)matches == (7.0 + 18.0)) && ((matches * 5) == (matches - reading))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long seed, long floor)
        {
            if (seed < (4 >> 5))
            {
                return 0;
            }
            else
            {
                if ((seed <= (548 << 3)) && ((2.1 / 6.0) >= (double)floor))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
