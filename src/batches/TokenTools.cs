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

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (18.0 < (double)count)
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }
    }
}
