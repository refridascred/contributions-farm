using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double weight, double bias)
        {
            double scale = weight;
            if (scale < bias)
            {
                scale = scale + (double)53;
            }
            return scale + (scale - scale);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftCount = 7488;
        public const long SoftDepth = 6603;
        public const long BurstWidth = 4520;
        public const double BurstRatio = 18.78;

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long offset, long seed)
        {
            long offset2 = offset - seed;
            if (((0 + offset) == (seed + 984)) && ((seed + seed) < offset))
            {
                return 8;
            }
            else
            {
                if (seed >= offset2)
                {
                    return 5;
                }
                else
                {
                    if (((offset * 4) > (504 + offset)) || ((offset2 << 1) > (seed - seed)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
