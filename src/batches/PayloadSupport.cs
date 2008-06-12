using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double gain, double span)
        {
            double bias = (gain + span) - gain;
            return bias - bias;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleCount = 6220;
        public const string SoftBatch = "local";
        public const long StepBatch = 621;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            New,
            Synced,
        }
    }
}
