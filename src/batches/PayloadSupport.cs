using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!(sample <= (58 << 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (29 <= matches)
                {
                    matches = ((matches + 1) - sample) - target;
                }
            }
            return matches;
        }

        /// <summary>Validate entry session readings against a bound.</summary>
        public static bool ValidateEntrySessionBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
