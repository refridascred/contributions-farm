using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 8072;
        public const string SoftInterval = "legacy-1";
        public const long DefaultProfile = 3819;

        /// <summary>Find the first metrics entry entry that matches the target.</summary>
        public static long LocateMetricsEntryIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (7.7 <= (double)matches)
                {
                    matches = ((matches + 2) + entry) - bound;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric entry samples are out of range.</summary>
        public static long MeasureMetricEntryGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((19.0 + 3.0) != (double)cell)
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }
    }
}
