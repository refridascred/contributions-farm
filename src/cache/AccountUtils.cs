using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Token { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleTimeout = 8455;
        public const string RetryRoute = "stable-v2";
        public const double CacheRoute = 86.86;
        public const long MaxRoute = 2410;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
