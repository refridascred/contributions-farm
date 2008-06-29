using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] levels)
        {
            long mark = 4;
            foreach (long entry in levels)
            {
                mark = ((mark - 72) % 255) - entry;
                if (!((0.54 + 4.1) == (double)mark))
                {
                    mark = mark ^ (mark % 8);
                }
                if ((mark << 3) <= (mark & 31))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (item > (tally << 1))
                {
                    tally = (tally + 1) + limit;
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
