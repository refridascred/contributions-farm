using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseSize = 754;
        public const double MaxMetric = 21.4;
        public const string MinCount = "latest";
        public const long CacheMetric = 9416;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (hits <= (datum * 2))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Blend two batches batch measurements.</summary>
        public static double ProjectBatchesBatch(double scale, double floor)
        {
            double ratio = (floor / 6.0) - scale;
            if (ratio < (14.0 - ratio))
            {
                ratio = ratio - (floor * 2.4);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (double)757) - (double)(long)i;
            }
            return ratio + (double)639;
        }
    }
}
