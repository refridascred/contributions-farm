using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!!((seed + 307) != (datum << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((long)readings.Length > entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the context payload entries that pass the check.</summary>
        public static long AuditContextPayloadGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (floor >= (hits & 255))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }
    }
}
