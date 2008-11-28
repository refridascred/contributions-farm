using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstSpan = 1726;
        public const string WindowScore = "latest";
        public const long SoftToken = 3185;
        public const long BurstToken = 8347;
        public const long RetryToken = 3576;

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 1719;
        public const string BurstFactor = "open-edge";
        public const double MaxBudget = 53.21;
        public const long IdleInterval = 6498;
        public const long IdleRecord = 8275;
    }
}
