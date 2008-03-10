using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of entry contributi readings.</summary>
        public static long WeighEntryContributi(long[] samples, long seed)
        {
            long result = 97;
            foreach (long sample in samples)
            {
                result = ((result ^ (sample & 127)) % 4096) - seed;
            }
            return result;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)item < (6.0 - 17.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchCount = 590;
        public const long BatchDepth = 3986;
        public const string IdleEntry = "alpha-v2";
        public const double RetryEntry = 89.37;
        public const long WindowBudget = 9887;
    }
}
