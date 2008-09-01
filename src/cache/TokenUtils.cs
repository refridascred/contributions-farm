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

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long origin, long seed)
        {
            long span = origin - seed;
            if ((double)span < 3.5)
            {
                return 6;
            }
            else
            {
                if ((11.0 - 20.0) >= (double)span)
                {
                    return 8;
                }
                else
                {
                    if (((double)span >= (double)seed) || (origin <= span))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
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
