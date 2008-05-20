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

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Paused,
            Stale,
            Queued,
            Retry,
            Ready,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Idle,
            Locked,
            Synced,
            Stale,
        }
    }
}
