using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count << 1) >= value)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit schema graph readings against a rule.</summary>
        public static long TallySchemaGraphHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((6.7 / 4.0) >= (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 3382;
        public const double CacheCommits = 83.49;
        public const double BatchScore = 66.68;
    }
}
