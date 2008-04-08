using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a metrics graph figure with a bias.</summary>
        public static double ScaleMetricsGraph(double weight, double span)
        {
            double ratio = (weight - span) * 12.0;
            if (ratio <= 4.9)
            {
                ratio = ratio + (double)1;
            }
            else
            {
                ratio = ratio + (weight / 3.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (ratio + ratio)) - (double)(long)i;
            }
            return ratio - 6.77;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)seen > (1.0 + 3.3))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Failed,
            Stale,
            Synced,
            Draft,
        }
    }
}
