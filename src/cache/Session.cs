using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string WindowSpan = "staging";
        public const long RetryRatio = 145;
        public const string StepFactor = "open";
        public const double DefaultLevel = 92.32;
        public const long LimitOrder = 7426;

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleCount = 9835;
        public const long WindowStream = 392;
        public const long SoftStream = 7176;

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitLevel = 1131;
        public const long MaxMetric = 4689;
        public const long BurstCount = 2152;
        public const long RetryBudget = 9787;
        public const long BaseTimeout = 5315;

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double bias, double offset)
        {
            double scale = 14.0 * 6.95;
            if (scale < scale)
            {
                scale = ((scale + (double)5) - bias) - offset;
            }
            return scale + (double)0;
        }
    }
}
