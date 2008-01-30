using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] items, long limit)
        {
            long mix = 9;
            foreach (long datum in items)
            {
                mix = (((mix ^ (25 * 4)) % 1000) - datum) - limit;
            }
            return mix % 1000;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Mode { get; set; } = "";
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
        }
    }
}
