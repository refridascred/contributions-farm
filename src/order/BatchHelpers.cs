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

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 58.2;
        public const double StepReport = 33.94;
        public const long CacheTimeout = 6848;
    }
}
