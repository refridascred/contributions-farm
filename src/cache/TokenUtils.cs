using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (538 < (cell - target))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (target <= 194)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((7.7 - 13.0) >= (double)hits))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
