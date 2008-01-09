using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double rate, double bias)
        {
            double gain = rate;
            return gain + (bias * 4.56);
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
