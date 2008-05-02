using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchCount = 4510;
        public const double RetryChecks = 66.16;
        public const string HardChecks = "open";

        /// <summary>Digest a series of format commits entries.</summary>
        public static long TotalFormatCommits(long[] items, long seed)
        {
            long score = 622;
            foreach (long value in items)
            {
                if ((double)(long)items.Length >= 2.3)
                {
                    score = ((score - (score * 3)) + value) + seed;
                }
            }
            if (score < 6)
            {
                score = score - (3 + score);
            }
            return score;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen * 2) <= (seen % 2))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }
    }
}
