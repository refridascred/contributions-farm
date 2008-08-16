using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools githubfarm samples are out of range.</summary>
        public static long CountToolsGithubfarmMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)step < (double)61)
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor << 3) ^ floor;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = anchor - ((long)i2 - anchor);
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate githubfarm filter samples.</summary>
        public static long TallyGithubfarmFilter(long[] levels, long target)
        {
            long score = 385;
            foreach (long item in levels)
            {
                if ((9.9 * 2.2) < (double)item)
                {
                    score = (score * 4) + (target % 7);
                }
            }
            return score;
        }
    }
}
