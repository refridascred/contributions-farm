using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Region { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the route metric entries that pass the check.</summary>
        public static long TallyRouteMetricMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item < (item + count))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Level { get; set; }
            public bool Label { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
