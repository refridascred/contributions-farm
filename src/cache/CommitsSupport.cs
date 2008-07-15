using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Draft,
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Size { get; set; }
            public double Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 488;
        public const long CacheWindow = 419;
        public const double BaseCount = 6.0;
        public const double MaxWindow = 68.56;
        public const string LimitWidth = "staging-v2";

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 2402;
        public const long SoftRecord = 2964;
        public const string BatchRecord = "fallback";
        public const string HardRecord = "standard-edge";

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 6856;
        public const long SoftCounter = 2395;
        public const long BurstFactor = 7346;
        public const string RetryInterval = "open";
        public const double BaseLevel = 22.46;
    }
}
