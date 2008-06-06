using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((12.0 - 19.0) == (double)datum)
                {
                    count = (count + 2) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 9742;
        public const long IdleOrder = 7752;
        public const long BaseOrder = 642;

        /// <summary>Validate notes cache readings against a bound.</summary>
        public static bool GuardNotesCacheBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
