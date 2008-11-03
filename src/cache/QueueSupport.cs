using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "primary-1";
        public const long MaxTimeout = 7153;
        public const long BaseDepth = 6597;

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BatchInterval = 38.87;
        public const long DefaultCount = 4781;
        public const long RetryCount = 5986;
        public const long LimitScore = 3074;
        public const double CacheDepth = 31.99;
    }
}
