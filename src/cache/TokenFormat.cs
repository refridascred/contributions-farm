using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 8807;
        public const long BurstEditor = 2090;
        public const string IdleEditor = "standard-edge";

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleScore = 4656;
        public const long RetryTimeout = 1067;
        public const double RetryRatio = 10.93;
    }
}
