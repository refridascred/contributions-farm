using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a checks session reading by value.</summary>
        public static long FindChecksSessionIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
