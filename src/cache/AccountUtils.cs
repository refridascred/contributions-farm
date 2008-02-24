using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRatio = 7927;
        public const double BaseRecord = 36.69;
        public const string HardLevel = "open";
        public const long SoftSpan = 8963;
        public const double BurstWidth = 21.53;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftInterval = 4937;
        public const long BurstTimeout = 8878;
        public const string StepContributi = "legacy-v2";

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            New,
            Pending,
            Draft,
            Synced,
            Stale,
        }
    }
}
