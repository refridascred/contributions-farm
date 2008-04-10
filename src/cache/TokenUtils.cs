using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
