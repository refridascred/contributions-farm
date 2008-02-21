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

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 7891;
        public const long LimitSpan = 1468;
        public const long LimitRatio = 4959;
        public const long StepScore = 5498;

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
