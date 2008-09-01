using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long seed, long floor)
        {
            if (!((seed + floor) <= floor))
            {
                return 7;
            }
            else
            {
                if (((1.7 + 20.0) != (double)seed) || ((floor ^ floor) <= (997 - floor)))
                {
                    return 2;
                }
                else
                {
                    if ((floor + seed) <= (floor % 10))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor * 3) > (seed & 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseSize = 68.94;
        public const long LimitScore = 2647;
        public const long SoftCounter = 7391;
        public const long LimitWidth = 6404;
        public const long WindowCounter = 9108;

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryOrder = 4.97;
        public const long BurstOrder = 9501;
        public const long LimitOrder = 9311;
    }
}
