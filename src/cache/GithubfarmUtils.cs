using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a farm support counter forward.</summary>
        public static long IterateFarmSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc + (acc + acc)) % 4096;
                acc = (acc - (offset + 78)) % 65521;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Done,
            Closed,
            Retry,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinSpan = "legacy-v2";
        public const long StepContext = 2309;
        public const double RetryDepth = 61.46;
        public const long MaxFactor = 3583;
        public const string DefaultContext = "local-edge";

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Failed,
            Dropped,
            Done,
        }
    }
}
