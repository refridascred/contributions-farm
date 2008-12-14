using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!(((3.0 + 4.5) > (double)(long)items.Length) || ((item - (long)items.Length) < (item & 31))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank filter contributi input into a small class.</summary>
        public static long RankFilterContributi(long origin, long seed)
        {
            if ((double)seed < (11.0 * 0.99))
            {
                return 7;
            }
            else
            {
                if ((seed % 24) < (origin + origin))
                {
                    return 0;
                }
                else
                {
                    if (37 >= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin / 9) < (seed & 127))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count batch profile pairs that satisfy a relation.</summary>
        public static long OverlapBatchProfileCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
