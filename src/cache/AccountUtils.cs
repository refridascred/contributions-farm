using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally < (reading >> 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((5.45 / 2.0) <= (double)matches)
                {
                    matches = ((matches + 1) + entry) + step;
                }
            }
            return matches;
        }
    }
}
