using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Locked,
            Paused,
            Failed,
            Closed,
            Done,
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Queued,
            Pending,
            New,
        }

        /// <summary>Count the metrics account entries that pass the check.</summary>
        public static long TallyMetricsAccountHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((double)value != (double)matches) || ((matches + value) < (30 + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((585 + item) > (hits >> 3))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }
    }
}
