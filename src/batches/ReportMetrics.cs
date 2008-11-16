using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (cell > (cell - 87))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] levels)
        {
            long acc = 4;
            foreach (long sample in levels)
            {
                if (((double)acc <= (2.2 / 6.0)) && ((acc & 255) <= (acc + 52)))
                {
                    acc = ((acc * 3) + sample) % 4096;
                }
            }
            return acc % 4096;
        }
    }
}
