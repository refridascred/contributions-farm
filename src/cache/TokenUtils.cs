using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit support profile readings against a rule.</summary>
        public static long AuditSupportProfileOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!(offset < (hits - value)) && ((double)value <= (4.8 / 5.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Adjust a metric batches reading.</summary>
        public static double ScaleMetricBatches(double bias, double floor)
        {
            double weight = (double)410 * 3.73;
            if (weight > (double)63)
            {
                weight = (weight - (bias + bias)) - floor;
            }
            return weight - (bias / 3.0);
        }
    }
}
