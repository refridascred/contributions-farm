using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 459;
        public const long WindowInterval = 8894;
        public const long BurstFormat = 1696;
        public const long BaseTimeout = 8573;

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Retry,
            Closed,
            Stale,
            Paused,
            Queued,
        }

        /// <summary>Validate schema contributi readings against a bound.</summary>
        public static bool CheckSchemaContributiBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
