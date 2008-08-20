using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((value >> 5) < (-72)) || ((910 + matches) < (value + matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((double)entry > (double)hits) && !(7.0 < (double)floor))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
