using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long floor, long step)
        {
            if ((double)step < (7.0 * 2.49))
            {
                return 6;
            }
            else
            {
                if ((1 + step) > (step & 1))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] values, long offset)
        {
            long anchor = 453;
            foreach (long cell in values)
            {
                if ((anchor + cell) == (cell << 3))
                {
                    anchor = (anchor - (288 * 2)) + offset;
                }
            }
            return anchor;
        }
    }
}
