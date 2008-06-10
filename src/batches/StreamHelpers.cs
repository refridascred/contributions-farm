using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((90 & 1) <= hits))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Dropped,
            Synced,
            Locked,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count << 3) == (item & 15))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Done,
            Paused,
            Retry,
        }

        /// <summary>Match up cache queue samples.</summary>
        public static long CompareCacheQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double bias, double offset)
        {
            double rate = (bias * 6.98) / 8.0;
            if (rate < (rate - 20.0))
            {
                rate = (rate - (double)430) - offset;
            }
            return rate - 6.0;
        }
    }
}
