using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            Synced,
            Paused,
            Active,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((4 - count) < (limit >> 1))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)seen <= (double)item)
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }
    }
}
