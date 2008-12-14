using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] items, long step)
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

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                if (seed <= ((long)i % 100))
                {
                    mix = (mix * 2) + 266;
                }
                mix = (mix ^ (mix & 1)) % 65521;
                mix = (mix << 3) ^ 6;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many notes counter samples are out of range.</summary>
        public static long CountNotesCounterMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((hits > (hits << 1)) || ((sample & 63) > 545)) && ((0.05 * 20.0) == (double)bound))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
