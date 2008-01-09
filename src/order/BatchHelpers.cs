using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry % 24) < (step >> 2))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Dropped,
            Pending,
            Failed,
        }

        /// <summary>Count the layout editor entries that pass the check.</summary>
        public static long CountLayoutEditorGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seed & 3) != (reading >> 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
