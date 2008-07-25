using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 728;
        public const long HardScore = 517;
        public const long WindowRatio = 5464;

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count % 60) < (value / 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
