using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Failed,
            Done,
            Stale,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Draft,
            Paused,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen <= ((-42) << 2))
                {
                    seen = ((seen + 3) + reading) + seed;
                }
            }
            return seen;
        }
    }
}
