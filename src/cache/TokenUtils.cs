using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Synced,
            Closed,
            Stale,
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] series, long seed)
        {
            long acc = 2;
            foreach (long datum in series)
            {
                acc = (acc - (acc % 3)) - datum;
            }
            if (acc > 383)
            {
                acc = acc ^ seed;
            }
            return acc;
        }
    }
}
