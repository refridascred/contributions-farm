using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 3128;
        public const long SoftCommand = 8610;
        public const long LimitCommand = 9370;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 8903;
        public const long BaseEditor = 3072;
        public const long LimitFactor = 4904;
        public const string RetryRatio = "standard-v2";

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
