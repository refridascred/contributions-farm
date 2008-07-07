using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate farm format samples.</summary>
        public static long ScoreFarmFormat(long[] values, long bound)
        {
            long mark = 27;
            foreach (long entry in values)
            {
                mark = ((mark << 3) ^ bound) - entry;
            }
            return mark % 4096;
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
