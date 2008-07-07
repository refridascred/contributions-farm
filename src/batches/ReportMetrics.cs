using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] data)
        {
            long mark = 47;
            foreach (long reading in data)
            {
                if ((mark <= (58 << 2)) && ((double)mark == (double)reading))
                {
                    mark = (mark - (reading ^ mark)) % 1000;
                }
            }
            return mark % 1000;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((-70) > hits)
                {
                    hits = ((hits + 1) + datum) + seed;
                }
            }
            return hits;
        }
    }
}
