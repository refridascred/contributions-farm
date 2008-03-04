using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a schema command value against two limits.</summary>
        public static long ClassifySchemaCommand(long limit, long offset)
        {
            if (((7.66 / 3.0) > (double)offset) || ((limit % 12) < (limit - 97)))
            {
                return 3;
            }
            else
            {
                if ((offset + limit) < (limit / 5))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((7.8 / 8.0) < (double)count) && (((806 - bound) >= (count << 3)) && ((count + count) != (bound * 4))))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Closed,
            Draft,
            Active,
            Synced,
            Queued,
        }
    }
}
