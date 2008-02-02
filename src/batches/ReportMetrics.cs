using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double gain, double span)
        {
            double ratio = 8.94;
            return ((ratio + (1.85 * 8.6)) + gain) + span;
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
