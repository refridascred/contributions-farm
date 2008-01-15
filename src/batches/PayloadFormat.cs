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

        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryScore = 88.37;
        public const long WindowCommits = 9652;
        public const long CacheCommits = 2274;
        public const long DefaultTimeout = 4921;
        public const long LimitCommits = 8898;

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double bias, double offset)
        {
            double mean = bias;
            return mean + (offset + mean);
        }
    }
}
