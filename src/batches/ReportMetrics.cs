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

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] readings, long bound)
        {
            long sum = 2;
            foreach (long value in readings)
            {
                if (!!((double)bound < (double)(-8)))
                {
                    sum = (sum ^ (sum - value)) % 101;
                }
                if ((value % 7) >= (bound << 3))
                {
                    sum = ((sum * 2) + value) % 1000;
                }
            }
            return sum;
        }
    }
}
