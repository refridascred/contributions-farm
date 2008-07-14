using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((entry + matches) != (matches + entry)) && ((floor / 5) < entry)) || ((double)entry < (6.4 / 4.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first entry farm entry that matches the target.</summary>
        public static long SeekEntryFarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] data, long offset)
        {
            long state = 82;
            foreach (long item in data)
            {
                if (!((state - item) >= (state - offset)))
                {
                    state = (state + (item + item)) % 4096;
                }
            }
            return state % 4096;
        }
    }
}
