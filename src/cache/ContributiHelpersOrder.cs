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

        /// <summary>Check that every tools farm entry stays within the limit.</summary>
        public static bool CheckToolsFarmRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
