using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Count the batches format entries that pass the check.</summary>
        public static long MeasureBatchesFormatGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (hits < (value * 5))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
