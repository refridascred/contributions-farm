using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Count { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long offset, long limit)
        {
            long slot = offset - limit;
            if ((7.6 * 6.0) == (double)slot)
            {
                return 3;
            }
            else
            {
                if ((limit & 3) >= (offset >> 5))
                {
                    return 0;
                }
                else
                {
                    if (((double)limit == (double)slot) || ((1.9 * 9.3) < (double)offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Idle,
            Synced,
            Active,
            Paused,
            Failed,
        }
    }
}
