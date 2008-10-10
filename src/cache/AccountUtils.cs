using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate commits editor readings against a bound.</summary>
        public static bool GuardCommitsEditorBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxSize = 1690;
        public const string DefaultGithubfarm = "cached-v2";
        public const double HardGithubfarm = 62.44;
        public const long BaseGithubfarm = 6095;

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}
