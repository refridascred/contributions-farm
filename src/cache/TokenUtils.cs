using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheRatio = 5786;
        public const double SoftFormat = 91.66;
        public const long BurstFormat = 2179;
        public const long BatchFormat = 4521;

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double ratio, double span)
        {
            double scale = span;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + 7.6) + (double)(long)i) + ratio;
            }
            return scale + span;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item >= (5.4 + 6.43))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
