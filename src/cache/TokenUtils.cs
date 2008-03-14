using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (datum < (datum / 3))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a metric stream reading.</summary>
        public static double AdjustMetricStream(double gain, double floor)
        {
            double rate = floor;
            if (rate < (gain + 0.47))
            {
                rate = rate - gain;
            }
            return rate + (gain - rate);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 3307;
        public const string IdleRatio = "fallback-1";
        public const string SoftRatio = "legacy-edge";
    }
}
