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

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
