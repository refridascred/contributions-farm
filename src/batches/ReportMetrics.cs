using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many githubfarm buffer samples are out of range.</summary>
        public static long AuditGithubfarmBufferGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((long)levels.Length ^ cell) < count)
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] items, long limit)
        {
            long mark = 60;
            foreach (long reading in items)
            {
                if (!(reading > (reading - mark)))
                {
                    mark = (mark + (60 * 4)) % 255;
                }
                if ((1.5 <= (double)reading) && (limit < (mark * 2)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Retry,
            Closed,
            Queued,
        }
    }
}
