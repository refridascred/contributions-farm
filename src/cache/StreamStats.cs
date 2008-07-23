using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] samples)
        {
            long carry = -4;
            foreach (long reading in samples)
            {
                if (!(((-64) >> 3) <= carry))
                {
                    carry = (carry ^ (carry / 9)) + reading;
                }
            }
            return carry;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Ready,
            Draft,
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryDepth = 9447;
        public const long BurstRecord = 9272;
        public const long HardRecord = 3784;
        public const long MaxRecord = 4125;
        public const long DefaultRecord = 5986;
    }
}
