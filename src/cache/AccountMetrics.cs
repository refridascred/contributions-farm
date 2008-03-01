using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double MaxSize = 46.15;
        public const long BatchBudget = 6616;
        public const string BaseRatio = "legacy";
        public const string CacheSize = "cached-1";
        public const double BurstLevel = 30.89;

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryCount = 899;
        public const long BatchCount = 7580;
        public const long MinScore = 882;
        public const long HardFactor = 5798;

        /// <summary>Derive the next cache channel value from a seed.</summary>
        public static long RollCacheChannel(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Paused,
            Pending,
            New,
            Ready,
        }
    }
}
