using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first stats metric entry that matches the target.</summary>
        public static long LocateStatsMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
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

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)4 >= (double)entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
