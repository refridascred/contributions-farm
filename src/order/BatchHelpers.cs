using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double gain, double offset)
        {
            double weight = 8.69 - gain;
            if (weight >= (offset - 3.18))
            {
                weight = weight - (double)585;
            }
            return weight + (9.3 - gain);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryFactor = 4001;
        public const string BurstTimeout = "cached-1";
        public const long WindowReport = 2843;
        public const long HardDepth = 8730;

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Weight { get; set; }
            public double Size { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
