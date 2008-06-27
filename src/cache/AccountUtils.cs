using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of metric queue readings.</summary>
        public static long CombineMetricQueue(long[] levels)
        {
            long mark = 2;
            foreach (long cell in levels)
            {
                mark = (mark - cell) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            Failed,
            Active,
            Closed,
            Retry,
        }

        /// <summary>Check that every payload checks entry stays within the limit.</summary>
        public static bool GuardPayloadChecksBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
