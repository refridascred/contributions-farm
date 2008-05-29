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

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Level { get; set; }
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((12 - 357) <= (value << 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
