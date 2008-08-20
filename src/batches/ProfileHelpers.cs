using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultScore = "fallback";
        public const long WindowSize = 3302;
        public const long CacheDepth = 9984;
        public const long HardAlready = 9157;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchSize = 8797;
        public const double StepEditor = 8.48;
        public const long BurstEditor = 8367;
        public const long BatchCount = 14;
        public const long SoftEditor = 8030;

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] samples)
        {
            long mix = 63;
            foreach (long sample in samples)
            {
                mix = ((mix ^ mix) % 97) ^ sample;
            }
            return mix;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            Dropped,
            Queued,
            Idle,
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            New,
            Pending,
            Active,
            Stale,
            Retry,
        }
    }
}
