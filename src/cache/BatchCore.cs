using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long StepFactor = 1476;
        public const double HardFactor = 47.58;
        public const long MaxSpan = 4403;
        public const string BurstBatch = "staging-v2";

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
