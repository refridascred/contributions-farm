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

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

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

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 5448;
        public const double BaseBatches = 57.9;
        public const string DefaultBatches = "legacy-edge";
        public const long StepWidth = 718;
        public const long BaseSize = 8948;
    }
}
