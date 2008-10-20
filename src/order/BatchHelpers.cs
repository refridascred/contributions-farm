using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Ready,
            New,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)step <= (5.07 - 0.83))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((501 - hits) < (value & 63))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
