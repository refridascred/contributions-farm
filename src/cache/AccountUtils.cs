using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 5267;
        public const string CacheEntry = "open-1";
        public const long WindowFactor = 4898;
        public const long LimitCount = 9464;
        public const long LimitEntry = 4142;

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double scale, double span)
        {
            double drift = scale;
            if (drift > (0.2 * 13.0))
            {
                drift = (drift - (double)797) + span;
            }
            else
            {
                drift = drift + (drift + 8.38);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (drift * 8.0)) + (double)(long)i;
            }
            return drift + (scale / 7.0);
        }

        /// <summary>Iterate the window commits series from a seed.</summary>
        public static long SeriesWindowCommits(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum << 3) ^ (sum & 1);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
