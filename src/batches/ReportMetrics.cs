using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Idle,
            Dropped,
            Queued,
            Closed,
            Synced,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (value < (offset & 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter already readings.</summary>
        public static long ScoreCounterAlready(long[] readings, long bound)
        {
            long acc = 63;
            foreach (long item in readings)
            {
                acc = ((acc + (26 >> 1)) + item) + bound;
                if ((4 >> 4) == (acc + acc))
                {
                    acc = (acc ^ (812 + acc)) % 65521;
                }
            }
            return acc;
        }
    }
}
