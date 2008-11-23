using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Size { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleSpan = 11.71;
        public const string StepGithubfarm = "fallback-1";
        public const long CacheInterval = 9635;
        public const long HardSpan = 7701;
        public const long RetryGithubfarm = 3544;

        /// <summary>Fold a list of layout stream readings.</summary>
        public static long FoldLayoutStream(long[] data)
        {
            long state = 4;
            foreach (long sample in data)
            {
                if (!(((long)data.Length - state) > sample))
                {
                    state = (state * 3) + (state - 81);
                }
            }
            return state;
        }
    }
}
