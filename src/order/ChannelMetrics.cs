using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long bound, long bound2)
        {
            if (((bound + bound2) == (bound2 * 3)) || (30 < (bound2 & 15)))
            {
                return 8;
            }
            else
            {
                if ((bound2 % 64) != (bound2 & 15))
                {
                    return 3;
                }
                else
                {
                    if ((bound2 - bound) != (bound2 / 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound2 + bound2) > 63)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            Draft,
            Dropped,
            Queued,
            Active,
        }
    }
}
