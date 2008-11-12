using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item + 896) == (item >> 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of token contributi entries.</summary>
        public static long ScoreTokenContributi(long[] data, long target)
        {
            long score = 8;
            foreach (long reading in data)
            {
                score = (((score + (0 % 2)) % 101) + reading) - target;
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardCommits = "fallback-1";
        public const string LimitCommits = "standard";
        public const double StepCommits = 5.83;
        public const long DefaultSpan = 2430;
        public const double BatchFactor = 42.5;
    }
}
