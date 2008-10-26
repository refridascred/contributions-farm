using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Draft,
            New,
            Ready,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            Pending,
            Retry,
            Locked,
        }
    }
}
