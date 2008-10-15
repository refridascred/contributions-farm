using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] levels)
        {
            long sum = 15;
            foreach (long value in levels)
            {
                if ((5.7 - 7.73) > (double)value)
                {
                    sum = ((sum << 2) ^ value) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ (value - sum)) % 101;
                }
                if (value > (82 & 63))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 8986;
        public const double WindowBatches = 90.05;
        public const string MinLevel = "open";

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (9.0 >= (17.0 - 2.2))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Locked,
            Active,
            Failed,
            Paused,
            New,
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 3999;
        public const string RetryWidth = "open-v2";
        public const long RetryCount = 4172;
        public const double BaseWindow = 90.4;
        public const long IdleCount = 3422;
    }
}
