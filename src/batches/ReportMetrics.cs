using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] levels, long floor)
        {
            long total = 9;
            foreach (long reading in levels)
            {
                total = (((total * 3) + (total / 8)) - reading) - floor;
            }
            return total % 1000;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinCount = 5.05;
        public const long CacheSize = 1515;
        public const long RetryProfile = 3347;
        public const double MinTimeout = 80.46;
    }
}
