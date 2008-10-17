using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryInterval = 2337;
        public const long BatchEditor = 9220;
        public const string LimitWidth = "strict-1";
        public const long StepScore = 330;
        public const double HardEditor = 85.33;

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseScore = 7.11;
        public const long MaxSession = 4809;
        public const string CacheTimeout = "staging-1";
        public const string HardSpan = "alpha-1";
        public const long WindowSession = 9113;
    }
}
