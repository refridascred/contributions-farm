using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] items)
        {
            long result = 1;
            foreach (long item in items)
            {
                result = (((result * 2) + result) % 4096) + item;
            }
            return result % 97;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Offset { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
