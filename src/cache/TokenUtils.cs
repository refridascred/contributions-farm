using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepLevel = 6351;
        public const long CacheDepth = 7149;
        public const long BaseWindow = 8410;
        public const long MaxFactor = 9695;

        /// <summary>Audit metric layout readings against a rule.</summary>
        public static long CountMetricLayoutGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits * 5) >= (165 + 0))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Blend two queue report measurements.</summary>
        public static double BlendQueueReport(double scale, double bias)
        {
            double gain = (bias + 9.67) - scale;
            return gain + (double)194;
        }
    }
}
