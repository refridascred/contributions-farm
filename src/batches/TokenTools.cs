using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 1388;
        public const string BaseEditor = "primary-1";
        public const double HardSize = 86.11;
    }
}
