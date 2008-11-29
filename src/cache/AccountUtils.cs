using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleCount = 62.55;
        public const double WindowProfile = 27.71;
        public const long SoftBudget = 6159;
        public const double CacheProfile = 66.17;

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Ready,
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
