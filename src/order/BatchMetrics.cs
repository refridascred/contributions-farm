using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            New,
            Active,
            Stale,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Queued,
            New,
            Synced,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Locked,
            New,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinDepth = 22.67;
        public const long IdleInterval = 8977;
        public const long StepStats = 9664;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches - matches) != (matches - entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepQueue = 69.33;
        public const long HardTimeout = 3140;
        public const double SoftCount = 9.45;
        public const long LimitBudget = 8143;
        public const long CacheBudget = 1027;
    }
}
