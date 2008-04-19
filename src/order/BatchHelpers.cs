using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long step)
        {
            long state = step;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate cache stream samples.</summary>
        public static long TotalCacheStream(long[] samples)
        {
            long mix = 72;
            foreach (long cell in samples)
            {
                if (((cell >> 2) > (mix >> 2)) || ((cell + cell) <= (mix + cell)))
                {
                    mix = (mix ^ (cell % 100)) % 97;
                }
            }
            return mix;
        }
    }
}
