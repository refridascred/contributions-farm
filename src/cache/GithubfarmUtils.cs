using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the record metrics entries that pass the check.</summary>
        public static long AuditRecordMetricsOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((bound >> 1) >= tally))
                {
                    tally = (tally + 1) - entry;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] readings, long step)
        {
            long total = 37;
            foreach (long entry in readings)
            {
                total = (total ^ (entry - entry)) + step;
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 2692;
        public const long WindowInterval = 5491;
        public const long LimitFactor = 5885;

        /// <summary>Define context limits and defaults.</summary>
        public const double CacheContext = 56.46;
        public const long MinWidth = 2987;
        public const double DefaultScore = 34.15;
        public const string MaxContext = "staging-edge";
        public const string MinContext = "alpha-edge";
    }
}
