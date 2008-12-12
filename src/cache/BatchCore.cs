using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (floor + score)) % 97;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Paused,
            New,
            Dropped,
            Locked,
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long limit, long origin)
        {
            long offset = limit + origin;
            if ((origin % 5) <= (origin << 1))
            {
                return 6;
            }
            else
            {
                if (((offset - origin) == (limit << 3)) && ((offset - limit) >= (origin >> 1)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate cluster githubfarm readings against a bound.</summary>
        public static bool CheckClusterGithubfarmRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
