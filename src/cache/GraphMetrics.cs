using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Pending,
            Ready,
            Queued,
            Failed,
        }

        /// <summary>Measure how many order command samples are out of range.</summary>
        public static long MeasureOrderCommandOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally >> 4) >= ((long)data.Length >> 2))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 587;
        public const long WindowScore = 3142;
        public const long MinBudget = 7353;

        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowSize = 3.97;
        public const long MaxRatio = 2637;
        public const double BaseMetric = 54.32;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Queued,
            Stale,
            Retry,
            Failed,
            Active,
        }
    }
}
