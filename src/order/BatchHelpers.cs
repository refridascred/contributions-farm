using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MinDepth = 1361;
        public const string CacheSize = "stable-edge";
        public const string RetryWidth = "legacy-edge";
        public const double BatchStream = 49.09;
        public const long BaseStream = 2925;

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double rate, double span)
        {
            double ratio = rate;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - (double)96) + (double)(long)i) + span;
            }
            return ratio + (ratio / 7.0);
        }
    }
}
