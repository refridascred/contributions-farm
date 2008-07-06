using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 1)
                    {
                        hits = hits + 1;
                    }
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
