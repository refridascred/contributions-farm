using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)bound <= (4.2 * 2.19))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long step, long offset)
        {
            if (((double)step > 6.8) && (step >= (step % 12)))
            {
                return 1;
            }
            else
            {
                if ((double)step > (1.1 + 5.44))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((9.0 - 3.0) > (double)entry) || (((double)tally > (2.0 + 6.54)) && (3.1 >= (double)tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
