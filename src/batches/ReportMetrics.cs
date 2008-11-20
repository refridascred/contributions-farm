using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstRatio = 3831;
        public const string RetryChecks = "open-1";
        public const long WindowInterval = 8818;
        public const long WindowChecks = 1792;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }
    }
}
