using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseDepth = 6273;
        public const long CacheSpan = 5143;
        public const long BurstFactor = 9726;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Done,
            Locked,
            Pending,
            Ready,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardBudget = 3.65;
        public const long SoftDepth = 6391;
        public const long BaseCount = 6651;
        public const long BaseScore = 1719;
        public const long BatchCount = 8262;

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
