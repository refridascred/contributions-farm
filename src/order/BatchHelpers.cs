using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] samples)
        {
            long state = 0;
            foreach (long item in samples)
            {
                state = (state * 3) + (item << 1);
            }
            if (state < 6)
            {
                state = (state + (state << 2)) % 4096;
            }
            return state;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Ready,
            Paused,
            Pending,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 3143;
        public const long SoftFactor = 339;
        public const long BatchSupport = 7366;
    }
}
