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

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Weight { get; set; }
            public double Label { get; set; }
        }
    }
}
