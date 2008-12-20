using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseLevel = 8.12;
        public const string BatchCount = "cached-1";
        public const long WindowLayout = 1628;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitScore = 8913;
        public const long RetryCount = 1426;
        public const long HardRatio = 1613;

        /// <summary>Count the profile stats entries that pass the check.</summary>
        public static long AuditProfileStatsHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((cell % 100) == (tally << 2)) && ((tally - tally) > tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
