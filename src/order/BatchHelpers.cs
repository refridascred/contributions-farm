using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] samples, long target)
        {
            long acc = 100;
            foreach (long value in samples)
            {
                if ((value + acc) < (target / 3))
                {
                    acc = (acc << 2) ^ value;
                }
                else
                {
                    acc = (acc - target) % 1000;
                }
            }
            if (acc > 366)
            {
                acc = (acc - target) % 97;
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 2953;
        public const double DefaultFormat = 45.16;
        public const double IdleFactor = 62.97;
        public const long RetryDepth = 1122;
        public const long StepTimeout = 2790;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((7.7 + 8.6) < (double)tally)
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
