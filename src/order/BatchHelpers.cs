using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Size { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Idle,
            Active,
            Queued,
            Synced,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
