using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)datum > (double)limit)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
