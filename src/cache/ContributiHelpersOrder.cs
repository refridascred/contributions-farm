using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Total { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit metrics stats readings against a rule.</summary>
        public static long TallyMetricsStatsHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((41 / 4) <= bound) || (((double)matches >= (double)value) || ((value + matches) < (value & 127))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchMetrics = 14.74;
        public const double MinTimeout = 8.78;
        public const string HardSpan = "open-v2";
        public const long MinMetrics = 609;
    }
}
