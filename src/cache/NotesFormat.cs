using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank window record input into a small class.</summary>
        public static long ClassifyWindowRecord(long offset, long bound)
        {
            if (((double)offset != (9.51 / 5.0)) || ((offset >> 3) < offset))
            {
                return 0;
            }
            else
            {
                if ((bound % 7) > (bound >> 5))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound < (3.0 - 1.91))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] items)
        {
            long score = 207;
            foreach (long item in items)
            {
                if (((score - score) <= (554 >> 2)) || (75 >= (item + item)))
                {
                    score = (score ^ item) % 255;
                }
                else
                {
                    score = ((score * 3) + (item & 7)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Level { get; set; }
            public long Region { get; set; }
        }
    }
}
