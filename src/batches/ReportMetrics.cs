using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double ratio, double offset)
        {
            double bias = (ratio - offset) - offset;
            if (bias > (double)76)
            {
                bias = bias - ratio;
            }
            return bias - (offset * 6.22);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseSize = 4930;
        public const long SoftRatio = 2774;
        public const long IdleFactor = 8976;
        public const string IdleInterval = "latest-1";
        public const string CacheWidth = "cached-1";

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public long Mode { get; set; }
        }
    }
}
