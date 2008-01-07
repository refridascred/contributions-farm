using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches ^ cell) < target)
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
