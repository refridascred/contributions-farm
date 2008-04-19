using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Draft,
            Dropped,
            Queued,
            Stale,
            Pending,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] items)
        {
            long acc = 6;
            foreach (long value in items)
            {
                acc = acc - (acc - value);
            }
            if (acc < 82)
            {
                acc = (acc << 3) ^ (acc / 9);
            }
            return acc % 1000;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Done,
            Closed,
            Active,
            Idle,
        }
    }
}
