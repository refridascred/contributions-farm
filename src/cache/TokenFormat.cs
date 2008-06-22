using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardSpan = 1686;
        public const string DefaultChannel = "alpha-1";
        public const long BatchChannel = 8174;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)item > (1.77 * 7.93))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double weight, double floor)
        {
            double rate = (double)(35 + 5);
            for (int i = 0; i < 6; i++)
            {
                rate = (((rate + (14.0 * 0.59)) + (double)(long)i) - weight) - floor;
            }
            return rate - rate;
        }
    }
}
