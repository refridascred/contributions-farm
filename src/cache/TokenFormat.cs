using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a entry order counter forward.</summary>
        public static long SeriesEntryOrder(long floor)
        {
            long total = floor;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            New,
            Active,
            Failed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitTimeout = 7047;
        public const long DefaultSize = 3730;
        public const long StepFilter = 3166;
        public const long DefaultFilter = 9022;
        public const double CacheFilter = 81.43;
    }
}
