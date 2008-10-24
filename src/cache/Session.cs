using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Ready,
            Retry,
            Closed,
            Done,
            Pending,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 2253;
        public const long BatchGithubfarm = 2795;
        public const string MinGithubfarm = "staging";
        public const long RetryCount = 4669;

        /// <summary>Validate buffer stream readings against a bound.</summary>
        public static bool ValidateBufferStreamRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
