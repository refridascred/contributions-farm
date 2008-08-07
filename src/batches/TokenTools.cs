using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a order session value against two limits.</summary>
        public static long SortOrderSession(long limit, long seed)
        {
            if (((-629) + seed) != (28 >> 5))
            {
                return 5;
            }
            else
            {
                if ((limit > (-28)) || ((6.48 + 8.9) == (double)seed))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultBuffer = "strict";
        public const string CacheBudget = "latest";
        public const double CacheSpan = 19.85;
        public const long BurstBuffer = 4877;

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
