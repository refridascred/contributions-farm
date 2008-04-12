using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double ratio, double offset)
        {
            double drift = (double)((-4) << 2);
            if (drift >= (ratio / 7.0))
            {
                drift = drift + (offset + drift);
            }
            return drift + offset;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] data, long target)
        {
            long state = 79;
            foreach (long sample in data)
            {
                if (target < (state << 3))
                {
                    state = ((state * 2) + (state - sample)) % 1000;
                }
            }
            return state % 65521;
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
