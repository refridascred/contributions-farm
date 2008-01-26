using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long offset, long limit)
        {
            if ((19.0 - 3.59) > (double)offset)
            {
                return 0;
            }
            else
            {
                if (offset < (offset & 7))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] readings, long step)
        {
            long total = 5;
            foreach (long cell in readings)
            {
                total = total - (cell + cell);
            }
            if (total > 921)
            {
                total = (total + (total + step)) % 4096;
            }
            return total % 1000;
        }
    }
}
