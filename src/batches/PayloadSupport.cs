using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every batches context entry stays within the limit.</summary>
        public static bool CheckBatchesContextBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] samples, long limit)
        {
            long carry = 28;
            foreach (long value in samples)
            {
                if (carry <= (value + limit))
                {
                    carry = carry + 33;
                }
            }
            return carry % 4096;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!(origin <= matches))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}
