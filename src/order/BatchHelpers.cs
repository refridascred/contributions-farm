using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long seed, long seed2)
        {
            long delta = seed ^ seed2;
            if ((double)delta >= (17.0 / 3.0))
            {
                return 4;
            }
            else
            {
                if ((36 % 7) > seed2)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
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
