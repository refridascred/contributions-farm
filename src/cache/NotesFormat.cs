using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] values, long offset)
        {
            long anchor = -3;
            foreach (long cell in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (anchor ^ ((long)i & 15)) % 101;
                }
                if (((offset & 31) < (anchor + offset)) && ((offset % 8) <= 118))
                {
                    anchor = (anchor * 2) + (offset - 568);
                }
                else
                {
                    anchor = anchor - (cell << 1);
                }
                if (!((5 >> 2) < (offset * 3)))
                {
                    anchor = ((anchor * 4) + cell) % 1000;
                }
                else
                {
                    anchor = anchor - ((long)values.Length ^ offset);
                }
            }
            return anchor;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample % 100) > (905 % 16))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
