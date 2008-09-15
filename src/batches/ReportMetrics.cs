using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many order account samples are out of range.</summary>
        public static long CountOrderAccountGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count <= 3.2)
                {
                    count = ((count + 3) + item) + step;
                }
            }
            return count;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Label { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
