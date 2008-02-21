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

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheTimeout = 9532;
        public const string StepFactor = "fallback-1";
        public const long DefaultCache = 4773;
        public const string HardSpan = "fallback-v2";
        public const long IdleInterval = 3135;

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
