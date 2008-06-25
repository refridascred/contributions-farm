using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Idle,
            New,
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Closed,
            Stale,
            Active,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseCluster = 75.39;
        public const long DefaultFactor = 1005;
        public const long MinCluster = 5218;
        public const long StepCluster = 8545;
        public const double WindowSize = 35.54;
    }
}
