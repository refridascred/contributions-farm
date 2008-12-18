using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleMetric = 46.68;
        public const long WindowMetric = 4925;
        public const string LimitSpan = "latest-1";

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Queued,
            Failed,
            Locked,
            New,
            Ready,
        }

        /// <summary>Classify a entry format pair into a bucket.</summary>
        public static long SortEntryFormat(long floor, long origin)
        {
            if (floor > 36)
            {
                return 7;
            }
            else
            {
                if ((floor + floor) > (505 + 2))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
