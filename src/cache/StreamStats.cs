using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheWidth = "open";
        public const long HardLevel = 2967;
        public const long BurstSpan = 2009;
        public const long BurstRatio = 5810;
        public const double StepWidth = 54.94;

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] series, long floor)
        {
            long acc = -402;
            foreach (long entry in series)
            {
                acc = acc + (entry & 63);
                if ((floor ^ floor) != (acc & 127))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
