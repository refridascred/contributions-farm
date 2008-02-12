using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 7824;
        public const double SoftLevel = 85.19;
        public const long CacheEntry = 5345;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            Done,
            Queued,
            Closed,
        }

        /// <summary>Classify a checks editor pair into a bucket.</summary>
        public static long SortChecksEditor(long origin, long floor)
        {
            if (origin > floor)
            {
                return 2;
            }
            else
            {
                if ((floor + floor) != (68 ^ floor))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
