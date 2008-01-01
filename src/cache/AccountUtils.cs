using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix << 2) ^ mix) % 4096;
                mix = (mix + (floor + floor)) % 101;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Active,
            Queued,
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
