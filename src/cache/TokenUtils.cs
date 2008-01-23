using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix + ((long)i >> 2)) % 4096;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit stats counter readings against a rule.</summary>
        public static long TallyStatsCounterHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((double)matches <= (double)cell) && (((cell << 1) <= (matches ^ matches)) || ((220 + 46) > (cell - matches))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (0 >= (sample ^ target))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
