using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long seed, long origin)
        {
            long prev = seed + origin;
            if ((prev & 31) > (origin << 2))
            {
                return 0;
            }
            else
            {
                if (((double)origin >= (7.1 / 9.0)) || ((prev / 4) >= (origin << 1)))
                {
                    return 2;
                }
                else
                {
                    if ((8.2 * 9.3) != (double)prev)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftBudget = 8984;
        public const long MinWidth = 8607;
        public const double HardScore = 59.49;
        public const long IdleRecord = 6327;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
