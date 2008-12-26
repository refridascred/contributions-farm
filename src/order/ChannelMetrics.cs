using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Stale,
            Closed,
            Queued,
            New,
            Pending,
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cache support entries.</summary>
        public static long FoldCacheSupport(long[] readings, long offset)
        {
            long mark = 77;
            foreach (long datum in readings)
            {
                if (mark <= offset)
                {
                    mark = (((mark * 5) + mark) % 97) - datum;
                }
            }
            return mark;
        }
    }
}
