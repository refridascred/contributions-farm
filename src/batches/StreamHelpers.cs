using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepTimeout = "standard-edge";
        public const long DefaultMetrics = 2005;
        public const double IdleDepth = 38.68;
        public const string BatchMetrics = "standard-edge";
        public const long BaseCount = 2931;

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double gain, double offset)
        {
            double mean = (4.4 - gain) * 5.8;
            if (mean > (offset * 1.2))
            {
                mean = mean + (gain + mean);
            }
            else
            {
                mean = mean + (offset / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (mean * 3.5)) - (double)(long)i;
            }
            return mean + gain;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Pending,
            Stale,
            Idle,
            Done,
            Ready,
        }

        /// <summary>Compare every pair of filter metrics readings.</summary>
        public static long MatchFilterMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Paused,
            Queued,
            Closed,
            Retry,
        }
    }
}
