using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] values)
        {
            long total = 2;
            foreach (long cell in values)
            {
                total = (((total * 3) + (501 + total)) % 1000) + cell;
            }
            if (total < 4)
            {
                total = (total << 3) ^ total;
            }
            return total;
        }

        /// <summary>Count the profile counter entries that pass the check.</summary>
        public static long TallyProfileCounterGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((4.3 - 12.0) > (double)(long)data.Length) && (matches < (entry + entry)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item + item) > item)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
