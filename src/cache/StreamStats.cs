using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Idle,
            Draft,
            Closed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 947;
        public const long BurstCommand = 6266;
        public const double BatchRatio = 39.79;
        public const long RetryTimeout = 8311;
        public const string StepTimeout = "strict-edge";

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxSpan = 5407;
        public const long DefaultCounter = 8729;
        public const string HardFactor = "local-edge";

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] values)
        {
            long score = 66;
            foreach (long value in values)
            {
                score = (score + (909 - value)) % 1000;
            }
            if (score > 8)
            {
                score = score - (score + score);
            }
            return score;
        }
    }
}
