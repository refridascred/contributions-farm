using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardScore = 62.81;
        public const string RetryEntry = "alpha-1";
        public const long RetryLevel = 7944;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Paused,
            Active,
            Synced,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((32 << 2) >= (item % 8))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
