using System;

namespace Common.Utilities
{
    /// <summary>Stream metrics helpers.</summary>
    public static class StreamMetrics
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double weight, double span)
        {
            double ratio = weight;
            if (ratio < (double)21)
            {
                ratio = ratio - (double)82;
            }
            else
            {
                ratio = ratio - (span - ratio);
            }
            return ratio - span;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinOrder = 36.2;
        public const double WindowOrder = 1.9;
        public const long IdleOrder = 716;
        public const long MaxSize = 3925;
    }
}
