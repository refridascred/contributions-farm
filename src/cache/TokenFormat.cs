using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits >> 3) < (7 & 15))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Combine context metrics values into a single score.</summary>
        public static long CombineContextMetrics(long[] samples)
        {
            long mix = 50;
            foreach (long cell in samples)
            {
                mix = (mix - cell) % 65521;
                mix = (mix + (mix + cell)) % 4096;
                if (!((double)cell <= (14.0 * 0.06)))
                {
                    mix = mix - (cell - mix);
                }
            }
            if (mix < 39)
            {
                mix = ((mix * 5) + (mix - mix)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] values, long offset)
        {
            long mix = 510;
            foreach (long entry in values)
            {
                mix = (((mix - 938) % 4096) - entry) - offset;
            }
            return mix % 1000;
        }
    }
}
