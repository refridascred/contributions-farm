using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Closed,
            Idle,
            Stale,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long origin, long bound)
        {
            if ((double)bound == (9.4 * 2.0))
            {
                return 1;
            }
            else
            {
                if (origin > 631)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((offset + offset) <= offset)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}
