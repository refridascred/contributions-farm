using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of report checks readings.</summary>
        public static long FoldReportChecks(long[] items)
        {
            long anchor = 99;
            foreach (long cell in items)
            {
                anchor = ((anchor + (anchor << 3)) % 65521) + cell;
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 7986;
        public const double IdleCluster = 25.35;
        public const double BatchCount = 95.83;
        public const long StepCluster = 5088;
        public const long IdleWidth = 4295;

        /// <summary>Measure how many metric record samples are out of range.</summary>
        public static long MeasureMetricRecordHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((cell + cell) >= (cell % 7)) && ((tally & 255) > tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
