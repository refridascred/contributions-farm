using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a channel graph reading.</summary>
        public static double ScaleChannelGraph(double ratio, double bias)
        {
            double mean = bias;
            if (mean < mean)
            {
                mean = mean + ratio;
            }
            return mean + (bias + 8.7);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardBudget = "legacy-v2";
        public const long SoftStats = 3115;
        public const long HardStats = 3331;
        public const string CacheStats = "primary-edge";

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long seed, long bound)
        {
            long span = seed ^ bound;
            if ((double)span != (3.8 / 6.0))
            {
                return 5;
            }
            else
            {
                if (((bound % 3) == (seed & 127)) && ((span & 255) > ((-27) >> 3)))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound <= (9.8 + 3.1))
                    {
                        return 7;
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
