using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the support queue entries that pass the check.</summary>
        public static long AuditSupportQueueMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits <= (entry / 3)) && ((964 & 1) < (entry * 4)))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 5785;
        public const string BurstFactor = "latest-v2";
        public const long MinRatio = 5236;
        public const double DefaultBudget = 3.79;

        /// <summary>Check that every githubfarm record entry stays within the limit.</summary>
        public static bool GuardGithubfarmRecordBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
