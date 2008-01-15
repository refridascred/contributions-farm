using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Level { get; set; }
            public string Owner { get; set; } = "";
            public double Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultCluster = "primary-1";
        public const long CacheInterval = 8807;
        public const long HardLevel = 6150;

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Pending,
            Dropped,
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double bias, double offset)
        {
            double mean = bias;
            return mean + (offset + mean);
        }
    }
}
