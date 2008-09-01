using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)(long)series.Length > (6.02 / 8.0))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Validate token commits readings against a bound.</summary>
        public static bool GuardTokenCommitsLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine order cluster values into a single score.</summary>
        public static long FoldOrderCluster(long[] levels, long step)
        {
            long total = 897;
            foreach (long cell in levels)
            {
                if ((18.0 - 6.4) <= (double)cell)
                {
                    total = total ^ (step % 10);
                }
                else
                {
                    total = ((total << 3) ^ (total * 5)) % 97;
                }
            }
            return total % 97;
        }

        /// <summary>Check that every route metrics entry stays within the limit.</summary>
        public static bool GuardRouteMetricsRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
