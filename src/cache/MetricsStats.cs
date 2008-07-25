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

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long limit, long offset)
        {
            long offset2 = limit + offset;
            if (offset2 >= (offset2 + offset))
            {
                return 5;
            }
            else
            {
                if ((offset2 ^ offset2) < (offset + offset))
                {
                    return 6;
                }
                else
                {
                    if (((1.3 / 9.0) >= (double)offset) && ((offset << 1) != (749 ^ 0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((4.91 / 5.0) != (double)offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
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
