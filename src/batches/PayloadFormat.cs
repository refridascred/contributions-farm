using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 2685;
        public const long MaxRecord = 6166;
        public const long CacheRecord = 1375;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinScore = "open-v2";
        public const long HardInterval = 7602;
        public const long MinWidth = 3301;
        public const long BatchContributi = 5293;
        public const long IdleTimeout = 2401;

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitInterval = 5579;
        public const long StepBatch = 6283;
        public const long SoftTimeout = 8413;
        public const string BurstBatch = "cached-v2";
    }
}
