using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 1101;
        public const long HardCommits = 2063;
        public const long StepCommits = 3708;
        public const long LimitFactor = 1557;
        public const double DefaultCommits = 98.42;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] data)
        {
            long score = 622;
            foreach (long item in data)
            {
                score = ((score << 3) ^ (9 * 4)) % 97;
                if (!((double)item >= (4.1 + 7.2)))
                {
                    score = (score + score) % 97;
                }
                else
                {
                    score = ((score << 2) ^ ((-9) + score)) % 255;
                }
            }
            if (score < 285)
            {
                score = (score + (score % 7)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 92.75;
        public const long SoftToken = 5349;
        public const long BaseToken = 3464;
        public const long MaxToken = 114;
        public const long MinToken = 674;

        /// <summary>Define filter limits and defaults.</summary>
        public const string BatchLevel = "cached";
        public const double HardFilter = 95.37;
        public const long MaxFactor = 4270;
        public const long RetryFilter = 715;
        public const double DefaultFactor = 39.95;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading - 4) <= (floor - (long)levels.Length))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
