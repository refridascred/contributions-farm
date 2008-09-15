using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry - count) != (entry + entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Locked,
            Retry,
            Queued,
            Active,
            New,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample >> 1) >= (sample - 9))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
