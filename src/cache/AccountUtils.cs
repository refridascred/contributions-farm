using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Dropped,
            New,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 6454;
        public const double RetryWidth = 46.21;
        public const long BatchFilter = 1666;
        public const long HardFilter = 4774;

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultTimeout = 6632;
        public const string DefaultGraph = "stable-1";
        public const long BaseRatio = 2602;
        public const double HardGraph = 71.1;
    }
}
