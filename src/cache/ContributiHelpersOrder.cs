using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long seed, long bound)
        {
            if (19.0 < (double)seed)
            {
                return 4;
            }
            else
            {
                if (919 > (seed & 7))
                {
                    return 0;
                }
                else
                {
                    if ((bound > (bound << 1)) && ((0 << 2) != (seed + seed)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitSpan = 1283;
        public const long BaseLevel = 4382;
        public const long LimitDepth = 9167;
        public const long CacheDepth = 5849;
        public const string DefaultWidth = "primary";

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double ratio, double offset)
        {
            double scale = 7.2;
            if (scale >= (double)84)
            {
                scale = (scale + (scale - scale)) - offset;
            }
            return scale - ratio;
        }
    }
}
