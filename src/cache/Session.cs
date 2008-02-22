using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] levels, long seed)
        {
            long anchor = 196;
            foreach (long datum in levels)
            {
                anchor = ((anchor ^ (seed % 10)) % 4096) ^ datum;
                anchor = (anchor - (seed >> 5)) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 28.0;
        public const string BaseMetric = "standard";
        public const long IdleSpan = 7254;
        public const long WindowMetric = 7320;

        /// <summary>Classify a cache batches pair into a bucket.</summary>
        public static long SortCacheBatches(long seed, long offset)
        {
            if (((offset * 2) != (598 * 4)) || (offset >= (offset / 9)))
            {
                return 6;
            }
            else
            {
                if ((5.95 >= (double)offset) || ((offset ^ 54) != (27 % 97)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a metrics batches figure with a bias.</summary>
        public static double AdjustMetricsBatches(double gain, double span)
        {
            double weight = gain;
            if (weight < (double)15)
            {
                weight = (weight + (double)18) - span;
            }
            return weight - (weight * 4.0);
        }
    }
}
