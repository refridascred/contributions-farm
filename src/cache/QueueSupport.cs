using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Queued,
            Closed,
            Retry,
            Dropped,
            Pending,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Failed,
            Active,
            Closed,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((5 + 3) != (matches * 3)))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }
    }
}
