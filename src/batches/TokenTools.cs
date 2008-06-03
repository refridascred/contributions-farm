using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double scale, double span)
        {
            double mean = (scale / 3.0) * 16.0;
            if (mean < (span * 1.3))
            {
                mean = mean - (span - span);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (1.9 - scale)) + (double)(long)i;
            }
            return mean - (mean + 0.92);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftStream = "standard-1";
        public const double IdleFactor = 15.69;
        public const long CacheStream = 7799;
        public const long MaxStream = 276;

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Size { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
        }
    }
}
