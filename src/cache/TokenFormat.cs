using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] levels, long floor)
        {
            long acc = 8;
            foreach (long sample in levels)
            {
                if (!(sample <= (sample - acc)))
                {
                    acc = (acc + floor) % 101;
                }
                else
                {
                    acc = ((acc << 3) ^ (sample & 63)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((double)datum >= (3.0 + 20.0)) && (((0.4 / 4.0) > (double)datum) || ((datum + 0) > (hits + hits))))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
