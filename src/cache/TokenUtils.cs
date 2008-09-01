using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] series, long floor)
        {
            long mix = 337;
            foreach (long entry in series)
            {
                if (20.0 > (double)floor)
                {
                    mix = ((mix * 4) + (mix ^ floor)) % 4096;
                }
                else
                {
                    mix = (mix - entry) % 101;
                }
            }
            if (mix > 3)
            {
                mix = (mix + (mix + mix)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long limit, long seed)
        {
            long edge = limit + seed;
            if ((edge - edge) > seed)
            {
                return 0;
            }
            else
            {
                if (!((limit - seed) <= (4 & 15)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 1.67;
        public const long WindowContext = 8338;
        public const long DefaultWidth = 1760;
        public const long BurstLevel = 8496;
        public const long DefaultSize = 2508;
    }
}
