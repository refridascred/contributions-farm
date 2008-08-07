using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Synced,
            Done,
            Failed,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] values)
        {
            long total = 10;
            foreach (long item in values)
            {
                if ((double)item == (17.0 + 7.07))
                {
                    total = (total << 3) ^ (item & 3);
                }
            }
            return total % 1000;
        }

        /// <summary>Count the editor batches entries that pass the check.</summary>
        public static long TallyEditorBatchesHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((seed - seed) < tally)
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }
    }
}
