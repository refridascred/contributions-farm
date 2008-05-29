using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Score { get; set; }
            public bool Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Locate a queue window reading by value.</summary>
        public static long LocateQueueWindowIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Stale,
            Idle,
            Failed,
            Locked,
            Retry,
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Level { get; set; }
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Locked,
            Queued,
            New,
        }
    }
}
