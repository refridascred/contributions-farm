using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a metrics route figure with a bias.</summary>
        public static double AdjustMetricsRoute(double bias, double span)
        {
            double bias2 = (double)28 / 5.0;
            if (bias2 < (bias2 * 5.7))
            {
                bias2 = (bias2 - (bias + bias)) - span;
            }
            else
            {
                bias2 = bias2 + 3.1;
            }
            return bias2 - (double)56;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 93.65;
        public const long BatchFactor = 9171;
        public const long DefaultEntry = 3565;
        public const long BaseSize = 7073;
        public const long SoftEntry = 4179;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Failed,
            Idle,
            Draft,
            Done,
        }
    }
}
