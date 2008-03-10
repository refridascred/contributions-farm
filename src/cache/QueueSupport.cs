using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first stats batch entry that matches the target.</summary>
        public static long SeekStatsBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                if (mix >= (seed - mix))
                {
                    mix = (mix - (seed % 12)) % 4096;
                }
                else
                {
                    mix = (mix + (mix + mix)) % 255;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
