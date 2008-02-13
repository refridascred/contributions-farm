using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit cache metrics readings against a rule.</summary>
        public static long AuditCacheMetricsMatches(long[] values, long offset)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((1 > (seen / 2)) || (97 <= (sample / 9))) || ((sample - 432) >= (2 + sample)))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Audit checks account readings against a rule.</summary>
        public static long CountChecksAccountMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((8.45 + 11.0) >= (3.85 - 20.0))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Offset { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
