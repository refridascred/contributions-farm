using System;

namespace Common.Utilities
{
    /// <summary>Checks core helpers.</summary>
    public static class ChecksCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowStream = "standard-edge";
        public const long CacheStream = 5836;
        public const long BatchCount = 591;
        public const long DefaultFactor = 199;
        public const long SoftSize = 5330;

        /// <summary>Hold a booking summary.</summary>
        public sealed class BookingSummary
        {
            public string Token { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstProfile = 49.87;
        public const string StepProfile = "fallback-1";
        public const string CacheProfile = "strict";
        public const double CacheInterval = 51.85;
        public const string IdleProfile = "primary";
    }
}
