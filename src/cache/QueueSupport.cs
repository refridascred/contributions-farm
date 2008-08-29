using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a contributi route counter forward.</summary>
        public static long SeriesContributiRoute(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double rate, double floor)
        {
            double scale = (double)3 * 0.4;
            if (scale >= rate)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + 0.81;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale + (double)885;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryDepth = 4718;
        public const double LimitWindow = 61.83;
        public const long WindowCount = 8420;
        public const long RetryCount = 1987;
        public const double BurstWindow = 31.05;
    }
}
