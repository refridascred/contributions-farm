using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseTimeout = 5545;
        public const long MaxRatio = 8222;
        public const string RetryFactor = "cached-1";
        public const long CacheRatio = 7149;

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }
    }
}
