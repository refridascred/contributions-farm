using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseWidth = 2329;
        public const double WindowEntry = 22.27;
        public const long SoftEntry = 9408;
        public const string BatchEntry = "local-v2";

        /// <summary>Define window limits and defaults.</summary>
        public const string StepTimeout = "fallback";
        public const string MaxWindow = "alpha";
        public const long BatchWindow = 9333;
        public const long CacheWindow = 1435;
    }
}
