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

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((offset % 8) > (seen - seen))
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
