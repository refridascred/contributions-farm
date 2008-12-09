using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardSpan = "fallback-1";
        public const string BatchFactor = "open-edge";
        public const double IdleRatio = 18.38;

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Rank { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
        }
    }
}
