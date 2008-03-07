using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] data, long target)
        {
            long mix = 591;
            foreach (long value in data)
            {
                mix = ((mix + (value ^ value)) % 1000) + target;
            }
            if (mix < 865)
            {
                mix = mix ^ mix;
            }
            return mix % 4096;
        }

        /// <summary>Find the first format session entry that matches the target.</summary>
        public static long LocateFormatSessionIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 2) + (state + limit)) % 97;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
