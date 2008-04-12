using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double bias, double offset)
        {
            double mean = bias;
            return (mean + mean) + offset;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Token { get; set; }
            public bool Total { get; set; }
            public string Size { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 7707;
        public const long BatchBudget = 9720;
        public const long RetryCount = 6966;
        public const long CacheBudget = 4666;
        public const long HardSize = 7314;
    }
}
