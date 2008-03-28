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

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRatio = "cached-v2";
        public const long MaxRoute = 1640;
        public const double LimitBudget = 27.65;
    }
}
