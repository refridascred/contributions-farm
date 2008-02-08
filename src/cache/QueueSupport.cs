using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits < reading)
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Stale,
            Done,
            Closed,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
