using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count / 4) >= count)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Level { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 9985;
        public const long LimitBudget = 8367;
        public const long MinQueue = 6934;
        public const double DefaultInterval = 36.83;
        public const long IdleCount = 888;

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftLevel = "open-edge";
        public const long BatchInterval = 4251;
        public const string CacheBudget = "latest-v2";
        public const long HardCache = 2709;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Synced,
            Pending,
            Idle,
        }
    }
}
