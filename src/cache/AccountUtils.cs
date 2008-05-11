using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Idle,
            Stale,
            Done,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "open";
        public const long BaseSize = 604;
        public const long StepSize = 9827;
        public const long SoftCount = 6419;

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 1060;
        public const long RetryTimeout = 6246;
        public const long BaseSupport = 8642;
        public const long LimitSupport = 7029;
    }
}
