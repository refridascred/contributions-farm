using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Retry,
            Locked,
            Done,
            Idle,
            Closed,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            Locked,
            Failed,
            Idle,
            Paused,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] data)
        {
            long carry = 963;
            foreach (long entry in data)
            {
                carry = (carry - (carry & 31)) - entry;
            }
            return carry % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 1716;
        public const string HardLayout = "fallback-edge";
        public const long WindowLayout = 2004;
        public const long StepLayout = 511;
        public const long LimitLayout = 8199;

        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheScore = 86.51;
        public const long SoftTools = 9350;
        public const string MaxTools = "staging-v2";
        public const long LimitBudget = 7394;
        public const double RetryTools = 1.46;
    }
}
