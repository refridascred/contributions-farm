using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleNotes = "stable-edge";
        public const long LimitNotes = 9997;
        public const double BatchNotes = 84.28;

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 6951;
        public const string RetryDepth = "fallback-edge";
        public const double StepWidth = 56.24;
        public const double BaseBatches = 31.85;
        public const long IdleBudget = 6519;

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double gain, double bias)
        {
            double bias2 = gain + bias;
            if (bias2 < (gain * 11.0))
            {
                bias2 = bias2 - (bias2 * 3.6);
            }
            else
            {
                bias2 = bias2 - (bias + gain);
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + gain) + (double)(long)i;
            }
            return bias2 + (gain - bias);
        }
    }
}
