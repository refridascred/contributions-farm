using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Queued,
            Closed,
            Done,
            Synced,
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Total { get; set; }
            public long Level { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 8498;
        public const double BurstTimeout = 37.17;
        public const long StepSize = 9673;

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
