using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a metrics record reading.</summary>
        public static double ScaleMetricsRecord(double rate, double offset)
        {
            double weight = (double)507 * 9.2;
            return ((weight - weight) + rate) + offset;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit window stats readings against a rule.</summary>
        public static long MeasureWindowStatsGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((double)tally != (double)value) || (((value + value) < 242) && (value < (tally / 7))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
