using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 8292;
        public const double LimitBudget = 95.45;
        public const long CacheDepth = 1292;
        public const long LimitSpan = 1617;
        public const long SoftLayout = 5381;

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheBudget = "open-edge";
        public const long DefaultScore = 6096;
        public const long IdleInterval = 2002;
        public const long MaxFactor = 8383;
        public const double LimitWidth = 4.8;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long origin, long seed)
        {
            if ((-72) >= (origin - seed))
            {
                return 7;
            }
            else
            {
                if ((837 ^ seed) < 22)
                {
                    return 8;
                }
                else
                {
                    if ((seed >> 4) != (origin << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
