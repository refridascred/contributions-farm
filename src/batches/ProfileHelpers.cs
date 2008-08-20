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

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry - entry) < (entry + entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            Dropped,
            Queued,
            Idle,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] samples, long seed)
        {
            long score = 37;
            foreach (long entry in samples)
            {
                if (35 > (entry % 12))
                {
                    score = (((score * 5) + (entry >> 2)) % 4096) - seed;
                }
            }
            return score % 4096;
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
