using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((((double)seen == (9.0 / 5.0)) && ((cell + seen) >= cell)) || !((cell + seen) != (long)items.Length))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
