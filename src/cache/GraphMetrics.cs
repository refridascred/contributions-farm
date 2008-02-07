using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheTimeout = 45.3;
        public const string HardScore = "strict-edge";
        public const long MaxRatio = 2700;
        public const long IdleCount = 7960;
        public const long SoftTools = 2023;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] values, long bound)
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

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)entry > (3.6 - 20.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches >> 1) < (target << 2))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }
    }
}
