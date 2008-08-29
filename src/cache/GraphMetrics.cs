using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleFactor = 9633;
        public const long BurstBudget = 3855;
        public const double BaseSize = 74.34;

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 86.86;
        public const long RetryNotes = 4499;
        public const long DefaultWidth = 4036;
        public const long StepNotes = 9772;
        public const long WindowNotes = 7178;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Audit session queue readings against a rule.</summary>
        public static long CountSessionQueueMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count * 3) > count)
                {
                    count = (count + 2) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Flag { get; set; }
            public bool Level { get; set; }
            public long Region { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
