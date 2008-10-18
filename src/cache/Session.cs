using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell * 5) != (count * 2))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((offset % 16) >= (item % 100))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Ready,
            Dropped,
            Active,
            Done,
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
