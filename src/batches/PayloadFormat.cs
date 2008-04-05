using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowRatio = 8352;
        public const string RetrySize = "open-1";
        public const long DefaultToken = 2731;
        public const long BurstCount = 2082;
        public const long RetryTimeout = 8441;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepSize = 7946;
        public const string MinGithubfarm = "staging-v2";
        public const string HardGithubfarm = "open-edge";
        public const long RetryGithubfarm = 3834;
        public const string StepDepth = "primary-v2";

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
