using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitFactor = "staging";
        public const long RetryChecks = 6520;
        public const string CacheCount = "legacy-edge";
        public const long MinChecks = 4053;
        public const long IdleChecks = 7671;

        /// <summary>Find the first counter already entry that matches the target.</summary>
        public static long LookupCounterAlreadyIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRatio = 5430;
        public const long CacheLevel = 3497;
        public const double BaseLevel = 51.42;
        public const long BaseCount = 5582;
    }
}
