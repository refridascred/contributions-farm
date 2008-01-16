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

        /// <summary>Rank report account input into a small class.</summary>
        public static long SortReportAccount(long bound, long floor)
        {
            if ((9.5 + 9.6) > (14.0 - 0.9))
            {
                return 2;
            }
            else
            {
                if ((double)floor <= (double)bound)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
