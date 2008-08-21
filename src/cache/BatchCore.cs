using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] readings)
        {
            long state = 278;
            foreach (long reading in readings)
            {
                if ((reading << 3) != ((long)readings.Length - (long)readings.Length))
                {
                    state = state - reading;
                }
                state = (state << 3) ^ (state << 2);
            }
            return state % 1000;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] readings, long bound)
        {
            long acc = 681;
            foreach (long entry in readings)
            {
                if ((19.0 * 1.15) <= (double)bound)
                {
                    acc = ((acc << 2) ^ (entry / 4)) % 101;
                }
                else
                {
                    acc = (acc << 2) ^ (acc - acc);
                }
                acc = acc + (bound << 3);
                if (((54 - bound) == (bound >> 1)) && (entry < bound))
                {
                    acc = (acc << 3) ^ acc;
                }
            }
            return acc;
        }

        /// <summary>Audit contributi already readings against a rule.</summary>
        public static long MeasureContributiAlreadyGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell << 2) <= (hits * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
