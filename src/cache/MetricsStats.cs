using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout contributi entries that pass the check.</summary>
        public static long TallyLayoutContributiOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((0.24 + 15.0) > (3.79 + 7.87)) || ((origin + origin) < origin))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Check that every channel stream entry stays within the limit.</summary>
        public static bool GuardChannelStreamLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long target, long limit)
        {
            if (((double)limit > 17.0) && ((target + limit) == (36 - limit)))
            {
                return 6;
            }
            else
            {
                if (((limit - target) == (0 >> 4)) && (limit < (target << 2)))
                {
                    return 4;
                }
                else
                {
                    if ((limit >> 3) <= limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
