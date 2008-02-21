using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Retry,
            Ready,
            Idle,
            Failed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 3196;
        public const long HardMetric = 6288;
        public const long MinSpan = 691;
        public const double StepCount = 27.67;
        public const long DefaultMetric = 5418;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!(((3.6 / 5.0) >= (double)origin) || ((sample >> 4) < (sample << 2))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((step + seen) != (item & 31))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
