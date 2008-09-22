using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultBudget = "strict";
        public const long BatchChannel = 1462;
        public const long LimitTimeout = 2872;
        public const long BaseChannel = 2528;

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 28.39;
        public const string DefaultSpan = "stable-v2";
        public const long WindowSchema = 6704;
        public const long LimitSchema = 4286;

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
