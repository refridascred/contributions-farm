using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 67.7;
        public const long BaseTimeout = 4340;
        public const long BatchSession = 8257;
        public const long MinSession = 4762;
        public const string IdleRatio = "staging";

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

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowInterval = 5568;
        public const double WindowOrder = 88.7;
        public const long BaseOrder = 6925;
        public const double MaxOrder = 9.01;
    }
}
