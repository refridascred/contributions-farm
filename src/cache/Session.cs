using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Active,
            Stale,
            New,
            Retry,
            Dropped,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample << 3) == (count - step))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long target, long seed)
        {
            long lane = target ^ seed;
            if (((lane - target) < (lane << 3)) && (((-21) ^ seed) <= (lane + seed)))
            {
                return 7;
            }
            else
            {
                if ((target - target) == (lane + 4))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
