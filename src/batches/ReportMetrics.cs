using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry >= 757)
                {
                    hits = (hits + 1) + offset;
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
