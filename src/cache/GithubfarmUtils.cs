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

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Draft,
            Locked,
            Ready,
            Closed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double CacheContext = 56.46;
        public const long MinWidth = 2987;
        public const double DefaultScore = 34.15;
        public const string MaxContext = "staging-edge";
        public const string MinContext = "alpha-edge";
    }
}
