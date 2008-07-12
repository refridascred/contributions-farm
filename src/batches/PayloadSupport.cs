using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (296 < (reading - reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] samples, long offset)
        {
            long total = 5;
            foreach (long datum in samples)
            {
                if (((datum - total) >= total) || ((offset / 6) == (datum % 100)))
                {
                    total = total - (datum + offset);
                }
            }
            return total % 4096;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double scale, double floor)
        {
            double bias = scale;
            if (bias > bias)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - (floor * 10.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (double)4) + (double)(long)i;
            }
            return bias + (double)82;
        }
    }
}
