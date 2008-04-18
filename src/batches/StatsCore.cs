using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] values, long limit)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches - cell) >= (matches + cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count cache batches pairs that satisfy a relation.</summary>
        public static long CompareCacheBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a batches window figure with a bias.</summary>
        public static double AdjustBatchesWindow(double scale, double span)
        {
            double bias = scale;
            if (bias >= scale)
            {
                bias = (bias - 2.5) + span;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (double)68) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Find the first commits report entry that matches the target.</summary>
        public static long LookupCommitsReportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
