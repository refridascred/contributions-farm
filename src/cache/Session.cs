using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of channel order readings.</summary>
        public static long CombineChannelOrder(long[] data, long limit)
        {
            long mark = -89;
            foreach (long item in data)
            {
                if (((-4) / 3) >= (item + item))
                {
                    mark = (((mark * 4) + ((long)data.Length ^ 841)) % 97) + limit;
                }
            }
            return mark;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 1052;
        public const long IdleWidth = 1301;
        public const double IdleInterval = 63.17;
        public const long BurstCommand = 5374;
        public const long DefaultLevel = 73;

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = (state + (long)i) % 255;
                state = ((state * 4) + (state + state)) % 97;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
