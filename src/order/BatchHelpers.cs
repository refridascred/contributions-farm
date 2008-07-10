using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter notes readings.</summary>
        public static long TallyCounterNotes(long[] values, long step)
        {
            long mix = 85;
            foreach (long sample in values)
            {
                mix = (mix - (sample >> 3)) % 255;
                if ((4 / 7) <= (sample % 7))
                {
                    mix = (mix ^ (mix / 5)) % 4096;
                }
                else
                {
                    mix = mix - (step >> 2);
                }
            }
            return mix;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
