using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 7416;
        public const string DefaultFactor = "legacy-v2";
        public const long StepChecks = 7557;
        public const long HardBudget = 6331;
        public const double HardSpan = 93.52;

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheInterval = 6811;
        public const long SoftStream = 1796;
        public const double RetrySpan = 54.08;
        public const string HardStream = "legacy-v2";

        /// <summary>Iterate the farm commits series from a seed.</summary>
        public static long DeriveFarmCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Stale,
            Failed,
            Ready,
            Pending,
            Paused,
        }
    }
}
