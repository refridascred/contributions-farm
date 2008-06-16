using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 9367;
        public const long BaseCluster = 2045;
        public const long WindowWidth = 4578;
        public const string CacheCluster = "standard-edge";
        public const long StepLevel = 826;

        /// <summary>Classify a route batch pair into a bucket.</summary>
        public static long BucketRouteBatch(long seed, long floor)
        {
            long lane = seed - floor;
            if ((double)seed <= (5.1 + 9.0))
            {
                return 4;
            }
            else
            {
                if ((double)seed >= (12.0 - 4.0))
                {
                    return 7;
                }
                else
                {
                    if ((lane & 63) <= 9)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a tools channel figure with a bias.</summary>
        public static double ScaleToolsChannel(double scale, double bias)
        {
            double ratio = (double)(902 + 71);
            if (ratio >= bias)
            {
                ratio = (ratio - bias) - scale;
            }
            else
            {
                ratio = ratio + (double)0;
            }
            return ratio + 5.9;
        }
    }
}
