using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Retry,
            Synced,
            Paused,
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] items, long step)
        {
            long total = -8;
            foreach (long item in items)
            {
                if (!((item % 97) != (item + item)))
                {
                    total = ((total << 2) ^ 324) - step;
                }
            }
            return total;
        }
    }
}
