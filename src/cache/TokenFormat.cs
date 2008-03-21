using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 904;
        public const long MinRatio = 1607;
        public const long CacheWindow = 602;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Rank { get; set; }
            public double Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits - hits) > (43 ^ hits))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }
    }
}
