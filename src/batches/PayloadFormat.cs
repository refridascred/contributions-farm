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

        /// <summary>Check that every notes buffer entry stays within the limit.</summary>
        public static bool ValidateNotesBufferLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
