using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] items)
        {
            long mark = 30;
            foreach (long datum in items)
            {
                if ((double)mark <= (0.22 - 1.6))
                {
                    mark = (mark - (mark + datum)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] samples)
        {
            long anchor = 2;
            foreach (long reading in samples)
            {
                if (((reading ^ anchor) >= (anchor / 4)) && (91 < reading))
                {
                    anchor = anchor - anchor;
                }
            }
            if (anchor > 38)
            {
                anchor = anchor ^ (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Adjust a support channel reading.</summary>
        public static double ProjectSupportChannel(double weight, double offset)
        {
            double mean = weight;
            if (mean < (weight + mean))
            {
                mean = (mean - mean) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean - (weight - 11.0);
        }
    }
}
