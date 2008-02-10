using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 7391;
        public const string BurstSize = "fallback-v2";
        public const long MinWidth = 7085;

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Draft,
            Retry,
            Active,
            Ready,
            Queued,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Retry,
            Locked,
            Stale,
        }
    }
}
