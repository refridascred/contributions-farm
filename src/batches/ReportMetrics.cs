using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
