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

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Ratio { get; set; }
            public double Rank { get; set; }
        }
    }
}
