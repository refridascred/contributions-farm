using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Stale,
            Done,
            Paused,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] series, long limit)
        {
            long anchor = 9;
            foreach (long datum in series)
            {
                anchor = (((anchor + (anchor * 2)) % 97) ^ datum) + limit;
            }
            return anchor;
        }
    }
}
