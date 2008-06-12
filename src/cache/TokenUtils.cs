using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many route commits samples are out of range.</summary>
        public static long AuditRouteCommitsOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((602 & 63) != (value + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
