using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Validate schema profile readings against a bound.</summary>
        public static bool ValidateSchemaProfileLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the buffer batches entries that pass the check.</summary>
        public static long MeasureBufferBatchesGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((13.0 * 0.63) < (double)seed)
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long floor, long floor2)
        {
            if (((floor2 + 32) < (floor + floor2)) && ((floor2 & 127) <= (555 / 7)))
            {
                return 5;
            }
            else
            {
                if ((9.03 - 0.3) >= (double)floor)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
