using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine stats route values into a single score.</summary>
        public static long TotalStatsRoute(long[] series, long origin)
        {
            long mark = 1;
            foreach (long cell in series)
            {
                if ((mark - mark) > (mark + origin))
                {
                    mark = (((mark * 5) + mark) % 4096) ^ cell;
                }
                else
                {
                    mark = (mark - (origin * 4)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
