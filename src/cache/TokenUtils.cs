using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long limit, long seed)
        {
            if ((seed + limit) <= (limit - seed))
            {
                return 8;
            }
            else
            {
                if ((double)seed != (3.82 - 1.0))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
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
