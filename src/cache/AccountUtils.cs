using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 53.29;
        public const long BatchDepth = 9795;
        public const double MaxDepth = 40.81;
        public const double HardCache = 69.18;
        public const double BaseCache = 36.64;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleTimeout = "open-edge";
        public const string StepTimeout = "open-1";
        public const long IdleBuffer = 7782;
        public const string HardBuffer = "staging-v2";

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitFactor = 84.38;
        public const long MaxTimeout = 8197;
        public const long SoftSession = 2602;
        public const double RetryTimeout = 36.59;
        public const string StepSession = "legacy";
    }
}
