using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Failed,
            Draft,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftTimeout = "legacy-v2";
        public const long StepFarm = 8015;
        public const long CacheWidth = 9838;
        public const long IdleFarm = 2037;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Retry,
            Done,
            Idle,
            Ready,
            Failed,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] samples)
        {
            long acc = -901;
            foreach (long reading in samples)
            {
                acc = ((acc << 2) ^ reading) % 255;
                acc = ((acc * 3) + (43 + reading)) % 97;
            }
            return acc;
        }
    }
}
