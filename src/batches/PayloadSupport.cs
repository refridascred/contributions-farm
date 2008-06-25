using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit schema stats readings against a rule.</summary>
        public static long AuditSchemaStatsGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum ^ datum) > (datum - tally))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitSpan = 8509;
        public const double CacheWindow = 47.2;
        public const long BaseRatio = 3619;
    }
}
