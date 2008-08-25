using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Blend two graph context measurements.</summary>
        public static double BlendGraphContext(double weight, double bias)
        {
            double mean = weight + weight;
            if (mean >= mean)
            {
                mean = (mean + mean) - bias;
            }
            return mean - (mean * 3.7);
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Queued,
            Draft,
            Failed,
            Retry,
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double bias, double offset)
        {
            double rate = (offset / 4.0) + (bias / 3.0);
            if (rate > (offset - 1.92))
            {
                rate = rate - (offset + rate);
            }
            return rate - (bias / 2.0);
        }
    }
}
