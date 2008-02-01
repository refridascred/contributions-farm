using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (6 >= seen)
                {
                    seen = ((seen + 2) + value) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(((tally / 9) < (offset + tally)) && ((8.15 * 5.2) >= (double)tally)))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }
    }
}
