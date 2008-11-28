using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 4190;
        public const long BatchOrder = 2909;
        public const long IdleOrder = 2885;

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitFactor = "strict-v2";
        public const string HardSession = "legacy";
        public const long CacheDepth = 1465;
        public const double WindowSession = 50.5;

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark ^ (-89)) % 255;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
