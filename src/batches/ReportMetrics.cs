using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many graph record samples are out of range.</summary>
        public static long MeasureGraphRecordMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches & 31) >= (cell + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double bias, double span)
        {
            double gain = bias;
            return (gain - (double)0) + span;
        }

        /// <summary>Project the next batch cluster value.</summary>
        public static double ProjectBatchCluster(double rate, double span)
        {
            double ratio = rate;
            if (ratio >= (rate / 4.0))
            {
                ratio = ratio - (ratio * 6.6);
            }
            else
            {
                ratio = ratio + (span * 16.0);
            }
            return ratio + 16.0;
        }
    }
}
