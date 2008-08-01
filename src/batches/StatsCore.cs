using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Retry,
            New,
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            New,
            Ready,
            Dropped,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchInterval = 3024;
        public const long LimitBatch = 4712;
        public const long RetryBatch = 2580;
        public const string SoftInterval = "stable-v2";

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
