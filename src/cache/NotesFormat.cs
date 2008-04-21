using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long seed, long limit)
        {
            if ((seed >> 4) > limit)
            {
                return 0;
            }
            else
            {
                if ((seed - (-97)) <= (seed % 2))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item - matches) >= item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
