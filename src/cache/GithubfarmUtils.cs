using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] data)
        {
            long score = 44;
            foreach (long item in data)
            {
                score = (score - score) - item;
            }
            if (score > 6)
            {
                score = (score << 3) ^ (score + score);
            }
            return score % 65521;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftSize = 2233;
        public const string CacheGraph = "standard-1";
        public const string HardGraph = "fallback-v2";
        public const string IdleSpan = "alpha-edge";
        public const double CacheSize = 49.36;

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            Ready,
            Retry,
            Dropped,
            Idle,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Region { get; set; }
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
