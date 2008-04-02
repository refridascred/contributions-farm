using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstFilter = 47.25;
        public const long CacheFilter = 2509;
        public const long CacheSpan = 7149;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor + (anchor << 3)) % 65521;
                if (((double)floor < (double)(long)i) && (anchor <= floor))
                {
                    anchor = ((anchor << 3) ^ 545) % 1000;
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultOrder = 36.82;
        public const double DefaultScore = 88.12;
        public const long WindowOrder = 5982;
        public const long SoftLevel = 9449;
    }
}
