using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryStream = "staging-1";
        public const string LimitStream = "primary";
        public const string DefaultDepth = "standard-edge";
        public const long DefaultStream = 5755;

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Synced,
            Active,
            Locked,
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string IdleFarm = "latest-1";
        public const long HardFarm = 2355;
        public const long CacheLevel = 7206;

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Dropped,
            Ready,
            Locked,
        }
    }
}
