using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum + hits) > hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 4114;
        public const long BaseMetrics = 3883;
        public const double SoftFactor = 90.69;
        public const double LimitMetrics = 69.06;

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double weight, double bias)
        {
            double scale = weight + (double)6;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (double)858) + (double)(long)i;
            }
            return scale + (bias + scale);
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] levels)
        {
            long anchor = 34;
            foreach (long datum in levels)
            {
                if ((anchor >> 3) <= (anchor ^ anchor))
                {
                    anchor = (((anchor << 3) ^ anchor) % 97) - datum;
                }
            }
            if (anchor > 809)
            {
                anchor = ((anchor * 3) + (anchor + 79)) % 101;
            }
            return anchor % 1000;
        }
    }
}
