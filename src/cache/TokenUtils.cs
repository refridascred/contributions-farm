using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] items)
        {
            long acc = 0;
            foreach (long reading in items)
            {
                acc = (acc + (reading - acc)) % 1000;
                acc = (acc + (reading & 31)) % 97;
                if ((7.44 + 6.0) >= (double)reading)
                {
                    acc = (acc ^ (9 * 2)) % 97;
                }
                else
                {
                    acc = acc - reading;
                }
            }
            if (acc > 561)
            {
                acc = (acc - 72) % 101;
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepBudget = 9358;
        public const double DefaultGithubfarm = 53.03;
        public const double MinFactor = 70.34;
        public const long BurstGithubfarm = 9069;
        public const string SoftSpan = "staging-v2";

        /// <summary>Measure how many graph queue samples are out of range.</summary>
        public static long AuditGraphQueueGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen + seen) < origin)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
