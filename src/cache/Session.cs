using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((origin % 100) < (origin >> 1))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((35 * 3) != (item & 31))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every farm payload entry stays within the limit.</summary>
        public static bool VerifyFarmPayloadRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the entry checks entries that pass the check.</summary>
        public static long CountEntryChecksHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((8 ^ seed) < tally)
                {
                    tally = (tally + 1) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
