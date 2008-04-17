using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepBuffer = 52.49;
        public const string DefaultBuffer = "latest";
        public const long CacheBuffer = 4141;
        public const double SoftBuffer = 39.48;
        public const long RetryBuffer = 9799;

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultRatio = 7709;
        public const double DefaultOrder = 67.21;
        public const string MaxSpan = "standard-1";
        public const long RetryLevel = 3131;
        public const long RetryOrder = 3539;

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Token { get; set; }
            public long Flag { get; set; }
        }
    }
}
