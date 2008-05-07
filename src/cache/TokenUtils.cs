using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 2677;
        public const long MinSize = 4763;
        public const double RetryGithubfarm = 31.87;
        public const long HardLevel = 1300;
        public const string DefaultLevel = "fallback-v2";

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            Retry,
            Done,
            Paused,
        }
    }
}
