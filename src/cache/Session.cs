using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheInterval = 5111;
        public const long DefaultOrder = 2564;
        public const double BurstOrder = 25.91;
        public const string IdleOrder = "standard-1";

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((hits + offset) > (datum + datum)) && (947 > (datum & 31)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
