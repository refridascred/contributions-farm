using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((datum << 2) > datum) && (2.7 >= (double)floor))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((offset + offset) != (sample + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
