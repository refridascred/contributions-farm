using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Ready,
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Compare every pair of cluster batches readings.</summary>
        public static long MatchClusterBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((tally / 2) == (tally + reading)) && ((reading >> 4) <= tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
