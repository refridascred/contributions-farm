using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((((reading / 3) > (seen & 127)) && ((double)seen < (double)875)) || (seen > (reading - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the counter cache entries that pass the check.</summary>
        public static long MeasureCounterCacheMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((99 * 2) <= (limit - limit))
                {
                    count = (count + 2) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate already graph readings against a bound.</summary>
        public static bool ValidateAlreadyGraphBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
