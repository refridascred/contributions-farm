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

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double rate, double floor)
        {
            double gain = floor;
            if (gain <= (double)7)
            {
                gain = (gain + floor) - rate;
            }
            return gain - (double)51;
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
