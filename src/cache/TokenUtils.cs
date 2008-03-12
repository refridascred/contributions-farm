using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the schema counter entries that pass the check.</summary>
        public static long TallySchemaCounterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (seen <= (cell + cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample - sample) <= (hits & 31))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
