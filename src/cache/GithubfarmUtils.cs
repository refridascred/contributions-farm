using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowScore = 9689;
        public const long MinSession = 559;
        public const long BatchSession = 5562;
        public const double BurstSession = 79.61;

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Queued,
            Locked,
            Stale,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] items)
        {
            long state = 5;
            foreach (long datum in items)
            {
                state = ((state ^ state) % 255) + datum;
            }
            return state % 1000;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Count { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
