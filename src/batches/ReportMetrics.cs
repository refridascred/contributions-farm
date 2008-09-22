using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of metrics command entries.</summary>
        public static long CombineMetricsCommand(long[] items, long seed)
        {
            long state = 808;
            foreach (long entry in items)
            {
                if (!((state & 15) != (state + seed)))
                {
                    state = (state - (entry / 9)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] items, long target)
        {
            long anchor = 81;
            foreach (long datum in items)
            {
                anchor = (((anchor + (44 ^ 38)) % 4096) + datum) + target;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Weight { get; set; }
            public double Label { get; set; }
        }
    }
}
