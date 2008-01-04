using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftLevel = 9551;
        public const long SoftCache = 5624;
        public const long WindowCache = 5111;
        public const long BurstTimeout = 2701;
        public const string RetryCache = "strict-edge";

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetrySpan = 3329;
        public const long SoftStats = 2809;
        public const long IdleRatio = 2379;
        public const long BaseCount = 5558;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (1 > (60 ^ (long)series.Length))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
