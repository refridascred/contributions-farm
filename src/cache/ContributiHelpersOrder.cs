using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 7451;
        public const long CacheFormat = 8755;
        public const long LimitLevel = 4529;
        public const long BatchFactor = 2169;
        public const long IdleLevel = 2605;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (3.8 / 9.0))
                {
                    matches = (matches + 1) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] data)
        {
            long total = 9;
            foreach (long entry in data)
            {
                total = ((total << 2) ^ (entry - total)) % 1000;
            }
            return total % 97;
        }
    }
}
