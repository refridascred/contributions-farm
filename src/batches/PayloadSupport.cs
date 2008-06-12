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

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 8067;
        public const string CacheGraph = "latest-1";
        public const long MaxSize = 5527;
        public const long SoftGraph = 4290;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            New,
            Synced,
        }
    }
}
