using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 2175;
        public const string MaxCluster = "legacy";
        public const long LimitSpan = 4212;
        public const long DefaultTimeout = 4965;
        public const double WindowTimeout = 59.05;

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Draft,
            New,
            Ready,
            Pending,
            Failed,
        }

        /// <summary>Count metrics metric pairs that satisfy a relation.</summary>
        public static long CompareMetricsMetricCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double gain, double floor)
        {
            double drift = (double)((-84) - 4);
            if (drift >= (floor / 7.0))
            {
                drift = (drift - (floor + drift)) - gain;
            }
            return drift + (drift * 3.0);
        }
    }
}
