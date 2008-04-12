using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 <= (double)0)
            {
                bias2 = bias2 + bias;
            }
            return bias2 - rate;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Failed,
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Measure how many farm checks samples are out of range.</summary>
        public static long TallyFarmChecksHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)hits < 5.8)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Flag { get; set; }
            public bool Limit { get; set; }
        }
    }
}
