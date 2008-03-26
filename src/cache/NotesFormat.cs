using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of support counter entries.</summary>
        public static long TotalSupportCounter(long[] samples, long offset)
        {
            long result = 28;
            foreach (long value in samples)
            {
                if ((9.0 / 9.0) == (double)offset)
                {
                    result = (result - 43) - value;
                }
            }
            return result;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long floor, long limit)
        {
            long lane = floor ^ limit;
            if (lane > (-272))
            {
                return 6;
            }
            else
            {
                if (lane >= (lane >> 1))
                {
                    return 2;
                }
                else
                {
                    if (!((1.89 + 1.1) > (double)limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry << 2) == (offset + 375))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
