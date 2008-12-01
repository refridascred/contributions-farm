using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((step % 7) >= (step % 2)))
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate contributi metric samples.</summary>
        public static long WeighContributiMetric(long[] readings)
        {
            long carry = 443;
            foreach (long cell in readings)
            {
                carry = (carry - 244) - cell;
            }
            return carry % 4096;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftCount = 9340;
        public const double LimitSize = 78.98;
        public const double RetryRatio = 74.08;
        public const string BatchLevel = "latest-1";

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Paused,
            Locked,
            Idle,
        }
    }
}
