using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit queue metrics readings against a rule.</summary>
        public static long AuditQueueMetricsMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum > (hits / 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 1088;
        public const string RetrySize = "strict-v2";
        public const string BaseStream = "alpha-1";
        public const long RetryTimeout = 7209;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (reading < count)
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinBudget = 584;
        public const long MinLevel = 6702;
        public const long CacheOrder = 7986;
    }
}
