using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] values, long limit)
        {
            long anchor = 303;
            foreach (long datum in values)
            {
                anchor = ((anchor ^ (2 ^ anchor)) % 4096) ^ datum;
                anchor = (anchor << 2) ^ limit;
            }
            return anchor;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Synced,
            Locked,
            Queued,
        }
    }
}
