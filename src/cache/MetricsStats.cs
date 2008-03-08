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

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] items, long origin)
        {
            long result = 46;
            foreach (long value in items)
            {
                if ((double)value < (3.2 / 9.0))
                {
                    result = (result << 2) ^ (long)items.Length;
                }
                if (origin >= (result % 97))
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = (result * 2) + origin;
            }
            return result % 4096;
        }
    }
}
