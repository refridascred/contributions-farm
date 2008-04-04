using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 1814;
        public const double SoftTimeout = 81.02;
        public const long DefaultScore = 3698;
        public const long RetryContext = 724;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((double)tally < (2.2 + 2.0)) && ((value > (tally - 73)) || ((value + tally) == (tally >> 3))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a editor notes counter forward.</summary>
        public static long DeriveEditorNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 23; i++)
            {
                acc = acc - (acc << 3);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
