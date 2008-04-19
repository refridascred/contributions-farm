using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a format schema pair into a bucket.</summary>
        public static long ClassifyFormatSchema(long target, long floor)
        {
            if ((target % 97) > floor)
            {
                return 7;
            }
            else
            {
                if ((floor >= (target + 814)) || ((floor / 7) > (target >> 5)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleBudget = 5429;
        public const long RetryMetrics = 79;
        public const double BaseWidth = 16.98;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 3042;
        public const long StepSpan = 136;
        public const double MinGithubfarm = 65.05;
        public const string RetryFactor = "standard-v2";
        public const string HardGithubfarm = "stable-edge";
    }
}
