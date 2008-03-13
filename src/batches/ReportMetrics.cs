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

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 9378;
        public const long SoftBatches = 6580;
        public const long LimitScore = 4165;
        public const long BaseBatches = 888;

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
