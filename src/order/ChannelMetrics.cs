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

        /// <summary>Count the session window entries that pass the check.</summary>
        public static long CountSessionWindowMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((double)entry >= (3.61 - 2.2)) && (entry < hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
