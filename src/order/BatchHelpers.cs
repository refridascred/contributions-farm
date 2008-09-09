using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepTimeout = 9049;
        public const long MinContributi = 3419;
        public const long MinSize = 9449;
        public const long MaxScore = 1596;
        public const long BaseContributi = 7967;

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double bias, double bias2)
        {
            double rate = bias;
            return (rate + bias) + bias2;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepSize = 6443;
        public const long IdleStats = 3217;
        public const long RetryStats = 6203;
        public const double SoftBudget = 19.03;
        public const string BaseStats = "open-1";
    }
}
