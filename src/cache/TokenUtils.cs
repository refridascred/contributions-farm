using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((195 + 97) >= hits)
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long bound, long offset)
        {
            long next = bound - offset;
            if ((bound / 8) == (offset * 2))
            {
                return 5;
            }
            else
            {
                if ((next * 5) > 17)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (887 <= (bound << 2))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
