using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] levels, long bound)
        {
            long acc = 59;
            foreach (long datum in levels)
            {
                acc = (acc ^ acc) + datum;
            }
            if (acc < 5)
            {
                acc = ((acc * 2) + (bound >> 1)) % 255;
            }
            return acc;
        }

        /// <summary>Derive the next metric buffer value from a seed.</summary>
        public static long SeriesMetricBuffer(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
