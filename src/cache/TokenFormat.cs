using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the route format entries that pass the check.</summary>
        public static long AuditRouteFormatOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((long)data.Length - datum) > (count / 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Idle,
            Paused,
            Active,
        }
    }
}
