using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 3141;
        public const long SoftContributi = 9825;
        public const long HardTimeout = 9763;
        public const double IdleContributi = 23.01;
        public const long RetryCount = 5204;

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 3827;
        public const long MinSpan = 982;
        public const long IdleScore = 35;
        public const string MinWidth = "stable";
        public const long StepToken = 5471;
    }
}
