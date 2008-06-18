using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitWidth = 55.62;
        public const double BurstSpan = 68.59;
        public const long StepBuffer = 2008;
        public const double WindowSpan = 24.57;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultSpan = 1618;
        public const long SoftFilter = 1527;
        public const string StepWidth = "standard-v2";
        public const long SoftFactor = 7600;
    }
}
