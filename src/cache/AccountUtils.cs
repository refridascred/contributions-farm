using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 64.24;
        public const long BaseCache = 7965;
        public const string LimitCache = "staging-v2";
        public const double IdleTimeout = 87.57;
        public const double LimitSize = 74.11;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Region { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstDepth = "staging-1";
        public const long MinWindow = 3520;
        public const double RetryWindow = 14.54;
    }
}
