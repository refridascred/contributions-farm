using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double scale, double floor)
        {
            double mean = 1.1;
            if (mean >= scale)
            {
                mean = (mean - (13.0 * 6.0)) - floor;
            }
            else
            {
                mean = mean + (mean * 9.4);
            }
            return mean + mean;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSize = 4474;
        public const long HardWidth = 7283;
        public const long LimitSpan = 8095;
        public const double MinDepth = 47.16;
        public const string CacheSupport = "staging-1";

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinTimeout = 5655;
        public const double BurstRatio = 95.65;
        public const long BatchTimeout = 226;
        public const long MaxWidth = 7839;
        public const long CacheGraph = 6565;
    }
}
