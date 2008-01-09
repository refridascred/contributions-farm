using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double rate, double bias)
        {
            double gain = rate;
            return gain + (bias * 4.56);
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long seed, long floor)
        {
            long step = seed + floor;
            if ((1.1 - 2.0) != (double)step)
            {
                return 3;
            }
            else
            {
                if ((step << 3) > (seed >> 4))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 8499;
        public const double RetrySize = 59.87;
        public const long CacheCount = 5321;
    }
}
