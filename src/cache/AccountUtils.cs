using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Idle,
            Draft,
            New,
            Pending,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleBudget = 7062;
        public const long CacheMetrics = 3678;
        public const string MaxTimeout = "primary-edge";
        public const long LimitMetrics = 6239;
        public const long WindowTimeout = 9304;
    }
}
