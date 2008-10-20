using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheChecks = 13.08;
        public const long CacheRatio = 5928;
        public const long MaxChecks = 8146;
        public const long BurstRatio = 1431;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((tally ^ tally) == (entry + entry)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
