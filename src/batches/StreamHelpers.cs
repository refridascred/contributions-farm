using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((entry << 3) > (matches & 1)) || (((-860) >> 1) == (751 + entry)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Closed,
            Failed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MinSpan = 15.19;
        public const double LimitScore = 58.63;
        public const long BaseTimeout = 5533;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ 720) < cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value / 6) <= 43)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
