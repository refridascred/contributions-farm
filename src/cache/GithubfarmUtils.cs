using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] values, long step)
        {
            long mark = 82;
            foreach (long entry in values)
            {
                if ((9.37 * 9.9) != (double)step)
                {
                    mark = (mark + (mark + mark)) - entry;
                }
                else
                {
                    mark = ((mark * 2) + ((-82) + mark)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] data, long origin)
        {
            long mark = 414;
            foreach (long item in data)
            {
                mark = (((mark - (804 - mark)) % 101) + item) + origin;
            }
            return mark;
        }
    }
}
