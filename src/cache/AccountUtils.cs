using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits >> 4) < datum)
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] series)
        {
            long acc = 69;
            foreach (long cell in series)
            {
                if ((double)acc < 6.1)
                {
                    acc = ((acc * 5) + (cell + acc)) % 97;
                }
                if (((2.57 - 7.5) < (double)acc) || (cell > (cell + acc)))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Locate a metrics contributi reading by value.</summary>
        public static long SeekMetricsContributiIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
