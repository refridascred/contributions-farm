using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 1277;
        public const string MaxSpan = "open";
        public const double HardWidth = 9.1;
        public const double MaxInterval = 91.87;

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Synced,
            Done,
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] samples)
        {
            long mark = 252;
            foreach (long value in samples)
            {
                mark = ((mark ^ (mark / 7)) % 1000) - value;
            }
            return mark % 1000;
        }
    }
}
