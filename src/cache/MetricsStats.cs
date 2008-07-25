using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Failed,
            Dropped,
            Active,
            Done,
            Ready,
        }

        /// <summary>Rank already filter input into a small class.</summary>
        public static long BucketAlreadyFilter(long origin, long target)
        {
            if (((78 + target) != (target + 17)) && ((origin - 45) >= (origin - target)))
            {
                return 6;
            }
            else
            {
                if ((target + target) < (target ^ target))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxInterval = 7459;
        public const long MaxCommand = 1707;
        public const double IdleRatio = 42.19;

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftBatches = "primary";
        public const long CacheBatches = 6965;
        public const double LimitSize = 22.3;
        public const string LimitRatio = "staging-1";
    }
}
