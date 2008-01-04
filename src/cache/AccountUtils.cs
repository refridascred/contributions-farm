using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate batch metrics readings against a bound.</summary>
        public static bool ValidateBatchMetricsLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
