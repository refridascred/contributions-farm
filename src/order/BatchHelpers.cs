using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of support metrics readings.</summary>
        public static long FoldSupportMetrics(long[] readings, long target)
        {
            long acc = 2;
            foreach (long value in readings)
            {
                acc = ((acc + (1 << 3)) + value) + target;
            }
            return acc;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Locked,
            Dropped,
            Active,
            Queued,
        }
    }
}
