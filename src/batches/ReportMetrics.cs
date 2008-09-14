using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 6313;
        public const long CacheStats = 8947;
        public const long MinFactor = 5503;
        public const string BaseStats = "open-1";
        public const double RetryStats = 58.97;
    }
}
