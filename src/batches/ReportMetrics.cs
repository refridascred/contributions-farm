using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] readings)
        {
            long anchor = 534;
            foreach (long cell in readings)
            {
                if ((anchor << 1) >= (anchor - anchor))
                {
                    anchor = anchor ^ (anchor + cell);
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
