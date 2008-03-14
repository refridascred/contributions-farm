using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Flag { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardOrder = "alpha-v2";
        public const long BatchOrder = 5005;
        public const double DefaultSpan = 69.65;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Owner { get; set; }
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long limit, long floor)
        {
            if ((limit << 1) <= (402 - floor))
            {
                return 1;
            }
            else
            {
                if (((952 * 4) < (limit * 3)) && (floor >= (floor ^ limit)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
