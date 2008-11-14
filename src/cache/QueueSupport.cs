using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double scale, double bias)
        {
            double mean = (double)(626 - 540);
            if (mean > (double)3)
            {
                mean = (mean - (double)9) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (scale / 8.0)) + (double)(long)i;
            }
            return mean + 4.32;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            New,
            Active,
            Stale,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (tally >= (origin + 8))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }
    }
}
