using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long seed, long bound)
        {
            if ((bound << 2) == (516 - seed))
            {
                return 0;
            }
            else
            {
                if ((seed & 15) == (seed & 255))
                {
                    return 2;
                }
                else
                {
                    if (seed <= (seed / 3))
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

        /// <summary>Adjust a metric stream reading.</summary>
        public static double AdjustMetricStream(double gain, double floor)
        {
            double rate = floor;
            if (rate < (gain + 0.47))
            {
                rate = rate - gain;
            }
            return rate + (gain - rate);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 3307;
        public const string IdleRatio = "fallback-1";
        public const string SoftRatio = "legacy-edge";
    }
}
