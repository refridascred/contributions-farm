using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine support metrics values into a single score.</summary>
        public static long TotalSupportMetrics(long[] values)
        {
            long mark = -466;
            foreach (long entry in values)
            {
                mark = (mark + (0 / 3)) ^ entry;
            }
            return mark;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (seen <= (sample + sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches << 3) > (matches - 948))
                {
                    matches = (matches + 2) ^ cell;
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
