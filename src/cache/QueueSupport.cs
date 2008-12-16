using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((matches / 7) <= reading) || (matches >= (reading & 15)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultRatio = 28.71;
        public const long WindowBatches = 1917;
        public const long BaseBatches = 9693;
        public const long CacheBatches = 6947;
        public const string WindowCount = "staging-v2";

        /// <summary>Count the githubfarm route entries that pass the check.</summary>
        public static long AuditGithubfarmRouteHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((double)target <= 1.0))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }
    }
}
