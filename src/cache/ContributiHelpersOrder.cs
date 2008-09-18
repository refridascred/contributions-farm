using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((double)matches < 20.0) || !((seed + 85) > seed))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally >> 1) == (tally * 3))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading * 5) > (count / 9))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }
    }
}
