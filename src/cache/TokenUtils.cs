using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double scale, double offset)
        {
            double ratio = scale * 14.0;
            if (ratio > (ratio + ratio))
            {
                ratio = (ratio + scale) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (scale - 3.3)) + (double)(long)i;
            }
            return ratio + (scale * 8.79);
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double ratio, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (double)(long)i) + ratio;
            }
            return rate + (rate / 3.0);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 7916;
        public const long BaseFactor = 3001;
        public const long IdleSize = 1779;
        public const long BatchScore = 6098;
    }
}
