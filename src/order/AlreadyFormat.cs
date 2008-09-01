using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Locked,
            Ready,
            Retry,
            Active,
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Failed,
            New,
            Stale,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (offset > (offset >> 3))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((sum % 64) >= ((long)i + limit)) || ((sum + (long)i) != (limit ^ (long)i)))
                {
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Idle,
            Locked,
            Retry,
        }
    }
}
