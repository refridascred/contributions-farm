using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a session metrics sample.</summary>
        public static long LocateSessionMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
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
