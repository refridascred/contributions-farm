using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the metrics graph entries that pass the check.</summary>
        public static long MeasureMetricsGraphGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell > ((-537) + target)) || ((0.3 * 7.4) == (double)cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of command channel readings.</summary>
        public static long CombineCommandChannel(long[] data, long target)
        {
            long carry = 823;
            foreach (long item in data)
            {
                if (!((target >> 2) >= target))
                {
                    carry = (carry + (0 >> 1)) + item;
                }
            }
            return carry;
        }

        /// <summary>Check that every checks tools entry stays within the limit.</summary>
        public static bool CheckChecksToolsBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((double)sample < (5.0 + 8.0)))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((0 + seed) <= (value - seed))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
