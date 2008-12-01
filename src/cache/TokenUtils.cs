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

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Draft,
            Synced,
            Ready,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Dropped,
            Draft,
            Ready,
        }
    }
}
