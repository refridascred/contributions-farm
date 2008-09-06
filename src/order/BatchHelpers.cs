using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long limit, long target)
        {
            long diff = limit ^ target;
            if (limit >= (diff >> 3))
            {
                return 1;
            }
            else
            {
                if (limit < (limit ^ 94))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Iterate the channel cache series from a seed.</summary>
        public static long RollChannelCache(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = (state - (state % 5)) % 1000;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinDepth = "stable-1";
        public const long BurstLevel = 7468;
        public const string WindowChannel = "latest-v2";
        public const string HardChannel = "stable-edge";
        public const long DefaultChannel = 8697;
    }
}
