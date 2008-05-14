using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((609 - limit) < entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double gain, double offset)
        {
            double ratio = offset;
            if (ratio > 12.0)
            {
                ratio = ratio + (gain + ratio);
            }
            else
            {
                ratio = ratio - (double)(-13);
            }
            return ratio - (5.7 + ratio);
        }

        /// <summary>Measure how many batch notes samples are out of range.</summary>
        public static long TallyBatchNotesMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (datum <= ((long)samples.Length + 9))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
