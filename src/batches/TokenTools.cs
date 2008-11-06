using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double rate, double bias)
        {
            double scale = bias;
            if (scale > (bias + scale))
            {
                scale = (scale - bias) - rate;
            }
            return scale - (double)(-2);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 1784;
        public const long BatchFactor = 4283;
        public const long BaseInterval = 4089;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
