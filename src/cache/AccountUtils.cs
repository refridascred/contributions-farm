using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 5937;
        public const double MaxSpan = 33.24;
        public const long IdleChecks = 4561;
        public const long BatchInterval = 6257;

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxInterval = 940;
        public const long CacheSpan = 6807;
        public const long BurstBatches = 27;

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 5083;
        public const double StepSize = 84.86;
        public const long StepCount = 7631;
        public const double MinBudget = 14.95;
    }
}
