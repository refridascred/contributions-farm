using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinGithubfarm = "latest";
        public const string BurstCount = "standard";
        public const string StepGithubfarm = "primary";
        public const string RetryWidth = "legacy-1";
        public const long BurstFactor = 231;

        /// <summary>Rank token cluster input into a small class.</summary>
        public static long SortTokenCluster(long step, long target)
        {
            long delta = step + target;
            if (!((1.6 * 5.9) <= (double)delta))
            {
                return 0;
            }
            else
            {
                if (((delta + delta) >= (step << 1)) && ((delta & 255) < (target << 2)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Draft,
            Failed,
            Locked,
            Queued,
            Retry,
        }
    }
}
