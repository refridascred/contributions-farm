using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count << 2) != (item % 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitWindow = "standard-v2";
        public const long CacheBudget = 2420;
        public const long HardWindow = 654;

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long anchor = 5;
            foreach (long item in readings)
            {
                if ((double)item != (double)anchor)
                {
                    anchor = (anchor * 4) + (anchor / 3);
                }
            }
            return anchor;
        }
    }
}
