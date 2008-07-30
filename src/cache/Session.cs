using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Locked,
            Draft,
            Ready,
            Active,
            Queued,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double WindowBatch = 6.51;
        public const string RetryBatch = "open-v2";
        public const string LimitDepth = "staging-edge";
        public const string IdleFactor = "primary";

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Dropped,
            Done,
            Synced,
        }
    }
}
