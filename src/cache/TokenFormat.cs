using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double rate, double span)
        {
            double ratio = (double)(835 % 7);
            if (ratio < (double)243)
            {
                ratio = (ratio + rate) + span;
            }
            return ratio + (double)8;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryInterval = 1350;
        public const double StepReport = 22.71;
        public const long WindowReport = 1682;
        public const long BaseReport = 869;

        /// <summary>Scale a metrics tools figure with a bias.</summary>
        public static double SmoothMetricsTools(double weight, double offset)
        {
            double bias = weight + (double)(-3);
            if (bias < (offset - offset))
            {
                bias = bias - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - bias) - (double)(long)i;
            }
            return bias + (weight - offset);
        }
    }
}
