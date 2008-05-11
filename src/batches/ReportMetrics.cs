using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseFactor = 2752;
        public const long MinBudget = 7375;
        public const long MinNotes = 8922;
        public const long MinInterval = 9885;

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowScore = 5395;
        public const long MaxLevel = 7255;
        public const double MinMetric = 68.63;
        public const double BurstCount = 51.19;
    }
}
