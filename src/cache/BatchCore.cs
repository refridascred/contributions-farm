using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string BaseTimeout = "legacy-edge";
        public const long BatchDepth = 6547;
        public const long BatchBudget = 6609;
        public const long RetryScore = 7975;
        public const string HardInterval = "open-1";

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Active,
            Stale,
            Done,
            Failed,
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Flag { get; set; }
            public bool Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
