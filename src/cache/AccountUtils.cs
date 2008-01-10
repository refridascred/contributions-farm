using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowInterval = "staging-v2";
        public const long WindowProfile = 6571;
        public const long BaseProfile = 1618;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!(tally > (tally - 6)) || ((double)tally < (2.1 / 8.0)))
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultWidth = 9944;
        public const long DefaultDepth = 3350;
        public const double BaseReport = 89.98;
        public const long SoftLevel = 2171;
    }
}
