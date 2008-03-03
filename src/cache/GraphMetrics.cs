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

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Region { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 876;
        public const long MinRatio = 6082;
        public const long CacheChannel = 1737;
        public const long WindowSize = 7520;
        public const long StepSpan = 8511;
    }
}
