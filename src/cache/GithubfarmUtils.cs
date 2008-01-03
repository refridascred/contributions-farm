using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Done,
            Paused,
            Failed,
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Active,
            Done,
            Ready,
        }

        /// <summary>Audit route report readings against a rule.</summary>
        public static long AuditRouteReportGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count * 3) < (30 + entry))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinWidth = 63.32;
        public const long WindowBatch = 7647;
        public const double MaxBatch = 90.29;
    }
}
