using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxFactor = 64.25;
        public const long MaxTimeout = 665;
        public const long StepFilter = 6752;
        public const string LimitBudget = "fallback-1";
        public const long RetryFilter = 4051;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstScore = 2223;
        public const long BaseBatches = 178;
        public const long BaseTimeout = 9463;
        public const double WindowBatches = 80.1;
        public const string IdleSpan = "strict-v2";

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSchema = "legacy-v2";
        public const string CacheSchema = "stable-1";
        public const long WindowCount = 6206;
    }
}
