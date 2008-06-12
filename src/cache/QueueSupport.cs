using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a context stream figure with a bias.</summary>
        public static double BlendContextStream(double bias, double offset)
        {
            double rate = (double)(0 + (-124));
            if (rate <= (bias - bias))
            {
                rate = rate + (bias + bias);
            }
            return rate - (5.33 - offset);
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Pending,
            Stale,
            Active,
            Ready,
        }

        /// <summary>Count the filter metrics entries that pass the check.</summary>
        public static long MeasureFilterMetricsHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((bound - hits) > 681)
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }
    }
}
