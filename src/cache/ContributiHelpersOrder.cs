using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 5; i++)
            {
                long slot = (floor << 2) >> 4;
                if ((floor >> 5) <= ((long)i * 2))
                {
                    mark = (mark + mark) % 255;
                    slot = ((slot << 2) ^ ((long)i - (long)i)) % 4096;
                    break;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = (((mark << 2) ^ (slot ^ floor)) % 101) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
