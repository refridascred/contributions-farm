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

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
