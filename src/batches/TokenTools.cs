using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftBudget = 2873;
        public const long StepDepth = 8252;
        public const double CacheTools = 40.01;

        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowInterval = 25.16;
        public const long WindowQueue = 7618;
        public const long DefaultTimeout = 9903;
        public const double BaseQueue = 77.62;
        public const long BaseSize = 3266;

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long step, long seed)
        {
            long cur = step ^ seed;
            if (cur <= (seed * 3))
            {
                return 6;
            }
            else
            {
                if ((step / 2) <= seed)
                {
                    return 3;
                }
                else
                {
                    if ((step > cur) && ((step >> 4) < 39))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed / 3) <= step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
