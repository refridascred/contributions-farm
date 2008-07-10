using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxRatio = 9175;
        public const string BatchCache = "alpha-edge";
        public const long HardLevel = 7532;
        public const string MaxCache = "primary-v2";
        public const string MinInterval = "strict-v2";

        /// <summary>Define channel limits and defaults.</summary>
        public const string SoftChannel = "standard";
        public const long DefaultBudget = 611;
        public const long LimitChannel = 1752;

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseCount = "open-v2";
        public const double StepInterval = 48.96;
        public const long RetryFilter = 7453;
        public const long HardFilter = 7843;
    }
}
