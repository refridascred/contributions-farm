using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the cache route entries that pass the check.</summary>
        public static long AuditCacheRouteOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((6.9 * 7.34) <= (double)matches))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry + entry) > (matches * 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
