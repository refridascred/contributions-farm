using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of batches route readings.</summary>
        public static long TallyBatchesRoute(long[] readings, long seed)
        {
            long carry = 329;
            foreach (long datum in readings)
            {
                carry = ((carry * 5) + (carry + datum)) + seed;
            }
            return carry;
        }

        /// <summary>Match up report channel samples.</summary>
        public static long CompareReportChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Failed,
            Locked,
            Synced,
        }
    }
}
