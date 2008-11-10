using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Active,
            Retry,
            Closed,
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryLevel = 4010;
        public const double IdleDepth = 60.83;
        public const double DefaultSupport = 42.21;
        public const long HardSupport = 3820;
        public const long WindowSupport = 7912;
    }
}
