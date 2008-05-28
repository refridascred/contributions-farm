using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the context report entries that pass the check.</summary>
        public static long CountContextReportHits(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell / 7) <= 76)
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Locked,
            Pending,
            New,
        }
    }
}
