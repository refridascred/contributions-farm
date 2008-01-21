using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Stale,
            Dropped,
            Locked,
            Pending,
            Ready,
        }

        /// <summary>Validate schema profile readings against a bound.</summary>
        public static bool ValidateSchemaProfileLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            New,
            Locked,
            Active,
            Synced,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long floor, long floor2)
        {
            if (((floor2 + 32) < (floor + floor2)) && ((floor2 & 127) <= (555 / 7)))
            {
                return 5;
            }
            else
            {
                if ((9.03 - 0.3) >= (double)floor)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
