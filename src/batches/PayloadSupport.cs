using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits + item) != (item * 2))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            Draft,
            Active,
            Queued,
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
