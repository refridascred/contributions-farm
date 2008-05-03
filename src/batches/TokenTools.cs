using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] series)
        {
            long mix = 65;
            foreach (long item in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = ((mix ^ item) % 97) - (long)i;
                }
                mix = (mix - (item * 4)) % 255;
                if ((mix - item) == (435 >> 1))
                {
                    mix = (mix ^ item) % 4096;
                }
            }
            return mix % 1000;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
