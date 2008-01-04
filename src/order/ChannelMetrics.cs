using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Idle,
            Closed,
            Done,
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((origin / 4) < (mark + 9))
                {
                    mark = (mark ^ (origin << 2)) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
