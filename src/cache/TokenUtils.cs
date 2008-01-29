using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxTimeout = 8563;
        public const double StepTimeout = 92.86;
        public const double CacheDepth = 7.6;
        public const long CacheToken = 969;
        public const long BatchToken = 5498;

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double scale, double span)
        {
            double ratio = (double)7 / 2.0;
            if (ratio < ratio)
            {
                ratio = (ratio - span) - scale;
            }
            else
            {
                ratio = ratio + (16.0 / 9.0);
            }
            return ratio - (double)6;
        }
    }
}
