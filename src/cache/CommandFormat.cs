using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit format batches readings against a rule.</summary>
        public static long TallyFormatBatchesOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 5) != (matches + cell))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((-3) + item) > item)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long bound, long bound2)
        {
            if ((60 - bound) > bound2)
            {
                return 3;
            }
            else
            {
                if ((double)(-8) != (double)bound)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowFactor = "stable-edge";
        public const double StepMetrics = 43.46;
        public const long DefaultTimeout = 1178;
        public const long LimitInterval = 1938;
    }
}
