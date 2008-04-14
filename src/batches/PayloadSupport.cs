using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((target & 127) >= target))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long step, long offset)
        {
            long cur = step ^ offset;
            if ((offset + cur) == ((-641) + 8))
            {
                return 6;
            }
            else
            {
                if ((offset - 5) >= 9)
                {
                    return 0;
                }
                else
                {
                    if (((offset + 4) >= step) && ((312 * 2) > (step ^ cur)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a layout format sample.</summary>
        public static long FindLayoutFormatIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
