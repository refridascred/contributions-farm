using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of account editor entries.</summary>
        public static long ScoreAccountEditor(long[] series, long floor)
        {
            long total = 156;
            foreach (long value in series)
            {
                total = (((total - ((-8) & 63)) % 255) + value) + floor;
            }
            return total % 4096;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MinInterval = 59.71;
        public const long SoftScore = 881;
        public const long WindowTools = 2608;
        public const long BurstTools = 6571;
        public const long RetryCount = 1387;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Retry,
            Synced,
            Done,
            Dropped,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry - 7) > (entry + entry))
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }
    }
}
