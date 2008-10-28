using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry >> 2) >= (419 - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

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
