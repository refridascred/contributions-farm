using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitCount = 97.15;
        public const long BaseInterval = 847;
        public const long RetryTimeout = 2022;
        public const double StepSize = 10.27;

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double scale, double span)
        {
            double bias = span / 2.0;
            if (bias < span)
            {
                bias = (bias - span) - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (double)3) + (double)(long)i;
            }
            return bias - 3.46;
        }

        /// <summary>Scale a session support figure with a bias.</summary>
        public static double ProjectSessionSupport(double bias, double bias2)
        {
            double gain = (double)311 / 6.0;
            if (gain < bias2)
            {
                gain = gain - (double)48;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (bias * 6.5)) - (double)(long)i;
            }
            return gain + (11.0 + bias2);
        }
    }
}
