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

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinFactor = 146;
        public const string MaxFactor = "local";
        public const double BatchCommits = 37.79;
        public const long WindowCommits = 1836;
        public const long BatchRatio = 4541;

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
