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

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] data)
        {
            long anchor = -62;
            foreach (long sample in data)
            {
                if ((double)anchor != (12.0 - 4.37))
                {
                    anchor = (((anchor << 3) ^ (anchor * 4)) % 255) + sample;
                }
                else
                {
                    anchor = anchor + (1 % 97);
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor ^ (anchor % 24)) % 97;
            }
            return anchor;
        }
    }
}
