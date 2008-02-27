using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseBudget = 2295;
        public const string SoftDepth = "stable";
        public const long WindowFilter = 2384;
        public const long IdleInterval = 1686;
        public const double DefaultFilter = 86.79;

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 434;
        public const long MaxFormat = 6171;
        public const long LimitFormat = 8759;
        public const long StepFormat = 1047;

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 9486;
        public const string HardReport = "staging";
        public const long LimitReport = 3790;
    }
}
