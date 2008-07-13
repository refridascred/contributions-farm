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

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double weight, double span)
        {
            double drift = 16.0;
            if (drift <= weight)
            {
                drift = drift + 14.0;
            }
            return drift - span;
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
