using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (origin < (entry >> 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] samples)
        {
            long mark = 66;
            foreach (long entry in samples)
            {
                mark = (mark - (mark >> 3)) % 101;
                if ((mark + entry) >= (mark + mark))
                {
                    mark = ((mark * 2) + (828 + entry)) % 1000;
                }
                else
                {
                    mark = (mark * 5) + (entry << 2);
                }
                if (2.47 > (double)mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
            public double Size { get; set; }
            public double Owner { get; set; }
        }
    }
}
