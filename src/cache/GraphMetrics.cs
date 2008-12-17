using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxWidth = "staging-v2";
        public const string CacheBuffer = "primary-edge";
        public const long LimitSpan = 129;
        public const long RetryBuffer = 1402;
        public const long CacheFactor = 1357;

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 86.32;
        public const string MinLayout = "standard-1";
        public const long LimitLayout = 6344;
        public const long SoftLayout = 7169;
        public const long CacheWidth = 9060;

        /// <summary>Define counter limits and defaults.</summary>
        public const double IdleDepth = 64.65;
        public const long CacheCounter = 4497;
        public const long BaseRatio = 6387;

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "primary";
        public const long StepScore = 2658;
        public const long IdleBatch = 203;
        public const double MaxBatch = 31.41;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
            public long Score { get; set; }
        }
    }
}
