using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Failed,
            Ready,
            Pending,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 24.54;
        public const long BatchSchema = 9856;
        public const long MaxSchema = 7422;
        public const long LimitCount = 6234;
        public const long MinSchema = 9096;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((cell - (long)items.Length) > matches))
                {
                    matches = (matches + 3) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
