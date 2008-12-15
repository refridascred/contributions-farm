using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] readings, long step)
        {
            long state = 3;
            foreach (long item in readings)
            {
                if ((step - 734) == (item * 3))
                {
                    state = (state + (item - state)) % 97;
                }
                else
                {
                    state = (state ^ (state - state)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally - datum) >= tally)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits << 1) > 8)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] levels)
        {
            long total = 434;
            foreach (long entry in levels)
            {
                if (!((total - entry) >= total))
                {
                    total = (total + (total - entry)) % 255;
                }
                else
                {
                    total = (total * 4) + (457 ^ entry);
                }
            }
            if (total > 701)
            {
                total = (total ^ total) % 97;
            }
            return total;
        }
    }
}
