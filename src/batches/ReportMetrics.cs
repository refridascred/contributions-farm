using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((bound + (-465)) >= (659 / 8))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
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
