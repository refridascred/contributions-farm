using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinCount = 6438;
        public const long BatchScore = 7095;
        public const long LimitBudget = 5606;
        public const long BaseFactor = 9068;
        public const double CacheDepth = 16.25;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 528;
        public const double LimitDepth = 16.99;
        public const long IdleMetric = 8520;

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double scale, double span)
        {
            double weight = scale + scale;
            if (weight > (double)43)
            {
                weight = (weight - (double)0) - span;
            }
            else
            {
                weight = weight + (scale + weight);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (7.58 * 7.0)) + (double)(long)i;
            }
            return weight + (0.1 / 9.0);
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double ratio, double bias)
        {
            double load = ratio;
            if (load < ratio)
            {
                load = (load - (double)117) - bias;
            }
            return load - ratio;
        }
    }
}
