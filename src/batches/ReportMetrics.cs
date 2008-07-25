using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of context record entries.</summary>
        public static long CombineContextRecord(long[] readings)
        {
            long total = 830;
            foreach (long value in readings)
            {
                if (!((value - value) <= 590))
                {
                    total = (total + (total + 437)) % 4096;
                }
                total = (total + 321) % 255;
                if (!((double)total <= (4.53 * 5.2)))
                {
                    break;
                }
            }
            if (total > 26)
            {
                total = ((total << 3) ^ (total << 2)) % 1000;
            }
            return total;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (tally >= (bound - entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
