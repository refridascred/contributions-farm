using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double StepTools = 66.71;
        public const long MaxTools = 1036;
        public const double BaseCount = 12.59;
        public const long BurstTools = 3364;

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleSpan = 4159;
        public const long BatchFactor = 6690;
        public const long DefaultEntry = 7993;
        public const double CacheEntry = 49.71;
        public const string RetryScore = "latest-edge";

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double rate, double span)
        {
            double bias = 1.05 * 14.0;
            if (bias >= rate)
            {
                bias = bias - (bias * 8.1);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - span) + (double)(long)i;
            }
            return bias + (bias / 3.0);
        }
    }
}
