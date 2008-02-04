using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double scale, double floor)
        {
            double mean = (double)(53 << 2);
            if (mean < mean)
            {
                mean = mean - (mean - scale);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + floor) + (double)(long)i;
            }
            return mean - (8.7 * 2.23);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitFactor = "fallback-edge";
        public const long CacheBudget = 61;
        public const long MaxTimeout = 146;
        public const long SoftDepth = 6187;
        public const long RetryInterval = 6016;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            Pending,
            Ready,
            Dropped,
            Locked,
        }
    }
}
