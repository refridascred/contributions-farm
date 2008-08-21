using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
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
