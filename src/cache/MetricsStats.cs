using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a route profile reading by value.</summary>
        public static long FindRouteProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every layout report entry stays within the limit.</summary>
        public static bool CheckLayoutReportLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Pending,
            Closed,
            Done,
            Active,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 6263;
        public const long BurstCount = 3348;
        public const double BurstInterval = 66.12;
        public const long WindowWidth = 7228;

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] items)
        {
            long mix = 736;
            foreach (long reading in items)
            {
                if ((double)reading > 0.3)
                {
                    mix = mix + reading;
                }
            }
            return mix;
        }
    }
}
