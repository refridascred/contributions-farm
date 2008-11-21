using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Ready,
            Retry,
            Done,
            Paused,
            Pending,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitContributi = 38.0;
        public const long WindowContributi = 2133;
        public const long HardDepth = 4922;
    }
}
