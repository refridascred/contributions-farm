using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 68.68;
        public const double StepSupport = 36.2;
        public const long BatchSupport = 1856;
        public const double HardTimeout = 54.05;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Pending,
            Done,
            Closed,
            Active,
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public double Owner { get; set; }
        }
    }
}
