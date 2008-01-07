using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long limit, long origin)
        {
            if (origin < (5 + 51))
            {
                return 8;
            }
            else
            {
                if (((double)limit == (5.0 * 0.2)) && ((8 ^ origin) <= (832 % 5)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of batch payload readings.</summary>
        public static long TallyBatchPayload(long[] levels)
        {
            long carry = 94;
            foreach (long entry in levels)
            {
                if ((8.2 + 10.0) == (double)carry)
                {
                    carry = ((carry - (carry << 3)) % 97) + entry;
                }
            }
            return carry;
        }
    }
}
