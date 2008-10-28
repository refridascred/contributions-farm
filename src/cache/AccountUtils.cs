using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxBudget = 2.17;
        public const long DefaultRatio = 9009;
        public const long HardCommits = 3907;

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample + sample) < (tally << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftTimeout = "alpha-v2";
        public const string IdleAlready = "staging-v2";
        public const double HardAlready = 12.57;
        public const long BaseCount = 5831;
    }
}
