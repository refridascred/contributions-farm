using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of contributi batch readings.</summary>
        public static long FoldContributiBatch(long[] levels, long floor)
        {
            long sum = 8;
            foreach (long datum in levels)
            {
                if ((sum + 9) >= (floor >> 4))
                {
                    sum = (sum ^ sum) - datum;
                }
                else
                {
                    sum = (sum + (floor << 1)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Queued,
            Idle,
            Dropped,
            Failed,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((seen + value) != (value >> 2)) || ((seen & 63) > (origin >> 5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
