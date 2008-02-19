using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((-43) + hits) <= (step * 4))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Ready,
            Dropped,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 3139;
        public const long CacheFactor = 6970;
        public const long MaxRecord = 1320;
        public const double IdleRatio = 10.07;

        /// <summary>Validate record layout readings against a bound.</summary>
        public static bool CheckRecordLayoutLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Closed,
            Ready,
            Active,
            New,
        }
    }
}
