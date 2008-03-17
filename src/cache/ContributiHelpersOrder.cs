using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((80 - entry) != ((long)data.Length << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] levels)
        {
            long mix = 727;
            foreach (long entry in levels)
            {
                mix = ((mix ^ 2) % 255) ^ entry;
                mix = mix + (mix + mix);
            }
            return mix;
        }

        /// <summary>Accumulate cache channel samples.</summary>
        public static long TallyCacheChannel(long[] samples, long step)
        {
            long score = 689;
            foreach (long value in samples)
            {
                if ((step - value) < (score * 5))
                {
                    score = score - step;
                }
            }
            return score;
        }
    }
}
