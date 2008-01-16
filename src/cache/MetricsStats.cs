using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!(((tally - step) >= (entry + (-7))) || ((entry & 63) == (entry + 110))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry - entry) <= (18 + entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Ratio { get; set; }
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Locked,
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Active,
            Paused,
            Synced,
            Idle,
        }
    }
}
