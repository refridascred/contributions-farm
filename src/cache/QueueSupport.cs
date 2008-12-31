using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine session format values into a single score.</summary>
        public static long FoldSessionFormat(long[] levels)
        {
            long result = -975;
            foreach (long entry in levels)
            {
                result = ((result << 3) ^ (0 ^ 3)) + entry;
            }
            return result;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Retry,
            Failed,
            Idle,
            Done,
            Pending,
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
            public bool Count { get; set; }
            public long Level { get; set; }
        }
    }
}
