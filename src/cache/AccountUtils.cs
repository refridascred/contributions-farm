using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long offset, long step)
        {
            if (((offset * 3) == (offset << 2)) || ((5.0 * 9.23) != (double)step))
            {
                return 1;
            }
            else
            {
                if ((offset + offset) > (29 + 713))
                {
                    return 6;
                }
                else
                {
                    if (14.0 <= (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Mode { get; set; }
            public bool Level { get; set; }
            public long Rank { get; set; }
        }
    }
}
