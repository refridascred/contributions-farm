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
    }
}
