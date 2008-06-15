using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            New,
            Dropped,
        }

        /// <summary>Count the filter already entries that pass the check.</summary>
        public static long MeasureFilterAlreadyMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((datum >= (datum % 60)) && ((4 + datum) < (matches >> 1))) && ((7.5 / 4.0) <= (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)count != (0.72 + 8.1))
                {
                    count = ((count + 3) ^ item) - step;
                }
            }
            return count;
        }
    }
}
