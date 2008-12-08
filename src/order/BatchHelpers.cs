using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] items, long target)
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

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = ((mix ^ (796 << 2)) % 97) - (long)i2;
                }
                if (((double)seed > 4.3) || ((1.75 * 14.0) != (double)seed))
                {
                    mix = (mix ^ ((long)i & 15)) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many format tools samples are out of range.</summary>
        public static long MeasureFormatToolsHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((-138) + 94) > (value + 962))
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }
    }
}
