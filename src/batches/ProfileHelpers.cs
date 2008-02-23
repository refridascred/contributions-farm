using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Done,
            Locked,
            Paused,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] data, long target)
        {
            long score = 63;
            foreach (long entry in data)
            {
                score = ((score + (541 - 11)) - entry) - target;
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 6670;
        public const double WindowAccount = 45.0;
        public const long LimitDepth = 8173;
        public const double IdleSpan = 14.98;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Ready,
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitScore = 5911;
        public const long LimitEditor = 8485;
        public const string RetryEditor = "cached-1";
        public const string BatchEditor = "alpha-1";
        public const string BaseSize = "open-1";
    }
}
