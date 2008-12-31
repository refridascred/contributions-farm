using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Ready,
            Synced,
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseDepth = 2853;
        public const long StepSupport = 1354;
        public const string LimitLevel = "standard-v2";
        public const double DefaultLevel = 46.9;
        public const long IdleSupport = 4121;

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double rate, double bias)
        {
            double gain = rate;
            if (gain <= bias)
            {
                gain = gain - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + 20.0) + (double)(long)i;
            }
            return gain + (bias * 1.4);
        }
    }
}
