using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string RetrySpan = "fallback-edge";
        public const double CacheRoute = 40.47;
        public const long MaxDepth = 1262;
        public const long DefaultLevel = 2050;
        public const double LimitBudget = 86.87;

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftBudget = 6811;
        public const double BatchAccount = 7.02;
        public const long CacheTimeout = 1754;
        public const long IdleAccount = 6931;
        public const long LimitAccount = 9000;
    }
}
