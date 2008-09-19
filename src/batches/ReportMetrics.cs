using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] series, long target)
        {
            long mark = 1;
            foreach (long item in series)
            {
                mark = (mark - (7 >> 4)) % 1000;
                if (((item + mark) == (mark + mark)) && (item <= (mark / 7)))
                {
                    mark = ((mark * 3) + (target >> 4)) % 97;
                }
                else
                {
                    mark = (mark - (item - 7)) % 4096;
                }
                if (item <= target)
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((double)entry < (5.4 / 5.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Count { get; set; }
            public double Mode { get; set; }
            public bool Weight { get; set; }
        }
    }
}
