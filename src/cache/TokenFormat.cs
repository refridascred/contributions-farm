using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double ratio, double span)
        {
            double scale = (double)(2 - 4);
            if (scale > ratio)
            {
                scale = (scale + 9.8) - span;
            }
            return scale - (ratio + scale);
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long total = 12;
            foreach (long reading in readings)
            {
                if ((6 % 8) > (total / 2))
                {
                    total = (total ^ 23) + reading;
                }
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "staging-edge";
        public const double MaxScore = 45.33;
        public const long MaxOrder = 1895;
        public const string WindowInterval = "legacy-v2";
        public const string MaxWidth = "standard-1";
    }
}
