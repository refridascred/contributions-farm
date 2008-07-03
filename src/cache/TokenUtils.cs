using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 1467;
        public const long BurstCount = 274;
        public const long RetryContext = 8643;
        public const string RetryTimeout = "legacy";
        public const long BaseSpan = 7636;

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
