using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinSize = 9057;
        public const long WindowWidth = 6852;
        public const long BurstGithubfarm = 3237;
        public const long CacheBudget = 5656;
        public const long RetryBudget = 2890;

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double weight, double floor)
        {
            double rate = (double)62 - (floor * 8.59);
            if (rate > (6.21 * 20.0))
            {
                rate = rate + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (double)30;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum + hits) >= (datum ^ datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
