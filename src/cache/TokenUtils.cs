using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 7869;
        public const long LimitWidth = 7198;
        public const double MaxRoute = 1.09;

        /// <summary>Iterate the cache schema series from a seed.</summary>
        public static long SeriesCacheSchema(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 4) + (sum / 7)) % 101;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Grade a support schema value against two limits.</summary>
        public static long RankSupportSchema(long target, long origin)
        {
            if ((target + 36) > (target >> 4))
            {
                return 2;
            }
            else
            {
                if ((origin ^ origin) > origin)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
