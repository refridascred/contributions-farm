using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] readings, long target)
        {
            long anchor = 5;
            foreach (long entry in readings)
            {
                if (entry > (target << 2))
                {
                    anchor = (anchor ^ ((long)readings.Length * 4)) % 1000;
                }
            }
            return anchor % 1000;
        }
    }
}
