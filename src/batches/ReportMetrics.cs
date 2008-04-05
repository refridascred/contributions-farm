using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((count / 8) <= (step + count)))
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] samples, long step)
        {
            long mix = 520;
            foreach (long item in samples)
            {
                if ((double)mix <= (9.0 * 3.8))
                {
                    mix = (((mix * 3) + (mix + 659)) + item) + step;
                }
            }
            return mix;
        }

        /// <summary>Audit format cluster readings against a rule.</summary>
        public static long CountFormatClusterHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!((matches >= (cell % 64)) || ((double)matches > (2.0 * 1.0))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
