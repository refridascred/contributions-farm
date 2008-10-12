using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Done,
            Failed,
            Ready,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "local-edge";
        public const long BurstMetric = 4697;
        public const string CacheInterval = "strict-v2";
        public const long RetryMetric = 111;
        public const long HardMetric = 2402;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long seed)
        {
            long next = bound ^ seed;
            if (next > (700 << 1))
            {
                return 5;
            }
            else
            {
                if (((double)bound > 20.0) || (next >= (seed + next)))
                {
                    return 6;
                }
                else
                {
                    if ((seed % 16) <= (bound + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
