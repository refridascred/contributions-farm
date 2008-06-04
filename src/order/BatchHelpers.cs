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

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long target, long step)
        {
            long lane = target + step;
            if ((811 * 5) == (lane << 1))
            {
                return 6;
            }
            else
            {
                if ((7.63 < (double)target) && ((step / 7) <= (target & 7)))
                {
                    return 8;
                }
                else
                {
                    if ((double)(-84) <= (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
