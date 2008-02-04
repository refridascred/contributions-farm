using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits >> 2) > (4 << 3))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading - 9) < offset)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Score { get; set; }
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
