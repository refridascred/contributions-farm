using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((item <= ((-5) ^ count)) && ((double)item <= (2.2 * 20.0))) && ((double)item == (9.7 / 9.0)))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
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
