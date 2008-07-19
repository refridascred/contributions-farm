using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 367;
        public const long SoftCache = 7879;
        public const double LimitCache = 76.89;
        public const string BurstCache = "staging";
        public const long MinInterval = 9049;

        /// <summary>Measure how many checks token samples are out of range.</summary>
        public static long AuditChecksTokenHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((limit >= (19 % 60)) || ((hits % 97) > (limit + limit)))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }
    }
}
