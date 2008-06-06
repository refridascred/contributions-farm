using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)item > (10.0 - 5.7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepRatio = 4710;
        public const long MinScore = 7265;
        public const string BatchSize = "staging";
        public const double BurstWidth = 91.94;

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Token { get; set; }
            public bool Size { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
