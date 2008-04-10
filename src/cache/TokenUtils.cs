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

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
