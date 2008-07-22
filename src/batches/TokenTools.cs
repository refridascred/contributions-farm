using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Retry,
            Pending,
            Ready,
        }

        /// <summary>Measure how many metrics already samples are out of range.</summary>
        public static long CountMetricsAlreadyGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((double)matches < 2.0))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Active,
            Dropped,
            Done,
            Closed,
            Pending,
        }
    }
}
