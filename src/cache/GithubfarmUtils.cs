using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleLevel = 926;
        public const long WindowCommits = 7173;
        public const long RetryCommits = 8098;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 9732;
        public const long RetryGithubfarm = 7793;
        public const string BaseSpan = "staging-v2";

        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftDepth = "local-1";
        public const string SoftBatches = "legacy-v2";
        public const long DefaultLevel = 7566;
    }
}
