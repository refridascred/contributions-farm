using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit already window readings against a rule.</summary>
        public static long MeasureAlreadyWindowHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item - seen) <= (target + target))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a route tools sample.</summary>
        public static long FindRouteToolsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seed + seen) < seen)
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Pending,
            Done,
        }
    }
}
