using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] readings, long offset)
        {
            long mark = -184;
            foreach (long item in readings)
            {
                mark = ((mark + (offset % 16)) % 1000) - item;
            }
            return mark;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count - count) <= (floor * 4))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Retry,
            Idle,
            Failed,
            Stale,
            Pending,
        }
    }
}
