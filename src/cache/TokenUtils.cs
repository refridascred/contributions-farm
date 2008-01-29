using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxBudget = 3756;
        public const string BaseSize = "fallback";
        public const long WindowCache = 3168;

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
