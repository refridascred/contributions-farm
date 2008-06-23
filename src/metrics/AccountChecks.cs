using System;

namespace Common.Utilities
{
    /// <summary>Account checks helpers.</summary>
    public static class AccountChecks
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Size { get; set; }
            public bool Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits - hits) <= (cell / 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long total = 74;
            foreach (long reading in series)
            {
                total = (total ^ (reading << 2)) % 255;
                total = (total * 4) + (total / 5);
            }
            return total % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstWidth = "legacy-1";
        public const long MinSession = 9577;
        public const long HardFactor = 7022;
        public const long MaxWidth = 7278;
    }
}
