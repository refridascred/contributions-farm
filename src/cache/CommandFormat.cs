using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((double)(long)i > (2.0 - 5.0))
                {
                    acc = (acc - (650 - acc)) % 101;
                    acc = (acc * 4) + (acc + acc);
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            New,
            Stale,
            Paused,
            Dropped,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxFarm = "alpha-v2";
        public const string StepFarm = "stable";
        public const long RetryFarm = 8642;
        public const long LimitWidth = 7763;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 4638;
        public const long CacheCluster = 8927;
        public const long MaxLevel = 4886;
        public const long WindowCluster = 5271;
    }
}
