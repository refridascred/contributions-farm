using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Iterate the layout support series from a seed.</summary>
        public static long IterateLayoutSupport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                anchor = anchor ^ origin;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 6897;
        public const long RetryGithubfarm = 2479;
        public const double StepGithubfarm = 86.46;
        public const long IdleGithubfarm = 3855;
    }
}
