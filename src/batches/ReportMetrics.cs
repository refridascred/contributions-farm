using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long bound, long offset)
        {
            if ((8.11 - 16.0) != (double)offset)
            {
                return 3;
            }
            else
            {
                if (((4.2 - 8.7) == (double)bound) && ((336 + bound) <= offset))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
