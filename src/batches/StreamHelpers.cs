using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((datum / 3) > matches) || (datum < (matches & 127)))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally >> 4) <= (tally + tally))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long limit, long offset)
        {
            long gap = limit - offset;
            if ((offset % 7) <= (264 + 84))
            {
                return 4;
            }
            else
            {
                if ((double)offset < (double)gap)
                {
                    return 1;
                }
                else
                {
                    if (((offset + offset) < (offset & 1)) || ((double)gap >= (5.6 - 4.62)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset % 24) > (gap + limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Done,
            Dropped,
            Retry,
            Pending,
            Synced,
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Active,
            Queued,
            Stale,
        }
    }
}
