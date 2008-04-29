using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Ready,
            New,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)reading <= (2.6 + 11.0))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((9.87 - 1.2) != (double)datum)
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }
    }
}
