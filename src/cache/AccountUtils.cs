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

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
