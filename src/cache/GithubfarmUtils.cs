using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] data, long floor)
        {
            long anchor = 99;
            foreach (long cell in data)
            {
                if ((cell / 4) < (anchor << 2))
                {
                    anchor = (anchor + (cell + cell)) + floor;
                }
            }
            return anchor;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long bound, long limit)
        {
            if ((bound << 3) == (limit & 15))
            {
                return 8;
            }
            else
            {
                if (((double)bound == (5.52 * 2.1)) && ((double)bound < (6.8 + 4.91)))
                {
                    return 7;
                }
                else
                {
                    if ((8.0 - 2.3) == (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the schema checks entries that pass the check.</summary>
        public static long CountSchemaChecksHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((12 - 165) >= value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
