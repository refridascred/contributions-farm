using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepInterval = 4301;
        public const double BurstTimeout = 35.29;
        public const long BurstCommits = 4427;
        public const string MinCommits = "legacy";

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleFactor = 7629;
        public const long WindowCommand = 5541;
        public const string DefaultSpan = "local-edge";
        public const long RetryCommand = 9703;

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Stale,
            Retry,
            Synced,
        }
    }
}
