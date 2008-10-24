using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long origin, long target)
        {
            if ((6.7 > (double)target) || (origin < (target ^ origin)))
            {
                return 2;
            }
            else
            {
                if ((origin + 4) > (target >> 2))
                {
                    return 6;
                }
                else
                {
                    if ((target + origin) == (21 & 127))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((0 - origin) >= (target + target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
