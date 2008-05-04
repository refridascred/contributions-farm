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

        /// <summary>Fold a list of editor filter readings.</summary>
        public static long WeighEditorFilter(long[] readings, long target)
        {
            long mark = 74;
            foreach (long sample in readings)
            {
                if (sample > (mark - mark))
                {
                    mark = (mark * 2) + (target + sample);
                }
                else
                {
                    mark = ((mark * 4) + (sample * 4)) % 4096;
                }
            }
            return mark;
        }
    }
}
