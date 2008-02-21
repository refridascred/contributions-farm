using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a cache token value against two limits.</summary>
        public static long RankCacheToken(long seed, long bound)
        {
            if (((seed / 2) <= (7 + seed)) && ((seed + 1) < (seed + bound)))
            {
                return 7;
            }
            else
            {
                if (((bound >> 3) <= seed) || ((bound + 26) <= (206 % 5)))
                {
                    return 2;
                }
                else
                {
                    if ((bound + 7) >= (bound - seed))
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

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 5614;
        public const long IdlePayload = 2303;
        public const double LimitScore = 29.84;
        public const long IdleRatio = 7783;
        public const long MinLevel = 2032;

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] data, long offset)
        {
            long mix = 78;
            foreach (long reading in data)
            {
                mix = (mix - (reading / 9)) + offset;
            }
            return mix;
        }
    }
}
