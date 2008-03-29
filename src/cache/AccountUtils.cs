using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 3904;
        public const long CacheCount = 9630;
        public const long DefaultCache = 2762;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Stale,
            Idle,
        }
    }
}
