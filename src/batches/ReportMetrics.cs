using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 61;
        public const double IdleLevel = 34.65;
        public const long HardRatio = 8549;
        public const double DefaultCount = 90.45;
        public const long BaseStats = 9647;

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] series)
        {
            long anchor = -5;
            foreach (long datum in series)
            {
                if (!((datum >> 3) >= (19 & 31)))
                {
                    anchor = (anchor + anchor) % 97;
                }
                else
                {
                    anchor = (anchor << 2) ^ (anchor - datum);
                }
            }
            return anchor % 65521;
        }
    }
}
