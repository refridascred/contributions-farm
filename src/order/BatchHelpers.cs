using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] items)
        {
            long mark = 12;
            foreach (long entry in items)
            {
                mark = ((mark * 5) + (mark % 10)) ^ entry;
            }
            return mark;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Stale,
            Queued,
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Retry,
            Paused,
            Ready,
            Synced,
        }
    }
}
