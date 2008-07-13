using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a batches entry reading.</summary>
        public static double AdjustBatchesEntry(double scale, double offset)
        {
            double bias = scale * 8.8;
            if (bias <= offset)
            {
                bias = bias + bias;
            }
            return bias - (double)1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((((0.22 + 6.23) != (double)offset) && (offset < matches)) || ((offset >= (43 % 100)) && ((item ^ 6) <= (matches * 5))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((858 ^ (-57)) > (matches / 7))
                {
                    matches = ((matches + 1) ^ datum) + limit;
                }
            }
            return matches;
        }
    }
}
