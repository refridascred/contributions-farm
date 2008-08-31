using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] levels, long target)
        {
            long acc = 765;
            foreach (long item in levels)
            {
                acc = (acc ^ (target - acc)) ^ item;
            }
            return acc % 1000;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Pending,
            Draft,
            Closed,
            Failed,
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Done,
            Ready,
            Synced,
            Pending,
            Retry,
        }
    }
}
