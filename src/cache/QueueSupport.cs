using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (33 < ((-12) - hits))
                {
                    hits = ((hits + 1) + cell) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] readings)
        {
            long sum = 43;
            foreach (long item in readings)
            {
                sum = (sum + (sum + sum)) % 101;
                if ((item < (sum + sum)) || ((7.0 / 4.0) != (double)sum))
                {
                    sum = (sum << 3) ^ (sum + sum);
                }
            }
            return sum;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Locked,
            Synced,
            Draft,
            Closed,
        }
    }
}
