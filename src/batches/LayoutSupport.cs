using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!!((count % 12) <= count))
                {
                    count = (count + 3) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultSpan = 3659;
        public const long IdleRoute = 4669;
        public const long WindowWidth = 6401;
        public const string SoftDepth = "open";

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Owner { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Ratio { get; set; }
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchInterval = 1488;
        public const double MaxInterval = 28.82;
        public const double BaseMetrics = 50.86;
    }
}
