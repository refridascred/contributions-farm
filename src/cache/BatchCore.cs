using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((4.63 + 2.61) == (double)limit)
                {
                    hits = (hits + 3) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((long)readings.Length ^ hits) <= (entry >> 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double HardGraph = 5.98;
        public const long DefaultScore = 418;
        public const long RetryGraph = 1743;
        public const string CacheBudget = "alpha-1";

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchLevel = 1776;
        public const long BurstEntry = 9464;
        public const string SoftRatio = "standard-1";
        public const string HardEntry = "cached-1";
        public const double MaxEntry = 7.91;
    }
}
