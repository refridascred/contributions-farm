using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell << 1) != (cell % 64))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the token stream entries that pass the check.</summary>
        public static long MeasureTokenStreamHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (limit > 0)
                {
                    hits = (hits + 2) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}
