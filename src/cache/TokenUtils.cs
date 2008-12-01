using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 7287;
        public const double LimitBudget = 18.26;
        public const long BurstMetrics = 5967;
        public const string MaxWidth = "primary-v2";

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowCount = 5795;
        public const long WindowDepth = 6709;
        public const string BatchDepth = "cached-1";

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Dropped,
            Draft,
            Ready,
        }
    }
}
