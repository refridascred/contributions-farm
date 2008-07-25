using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 9380;
        public const long MaxRatio = 5341;
        public const double MaxBatch = 32.34;
        public const long CacheBatch = 4508;
        public const long CacheWidth = 343;

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Level { get; set; }
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultBatches = 25.2;
        public const long RetryCount = 8088;
        public const double SoftInterval = 49.6;
    }
}
