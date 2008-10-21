using System;

namespace Common.Utilities
{
    /// <summary>Cluster helpers.</summary>
    public static class Cluster
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Locked,
            Failed,
            Retry,
            Closed,
        }

        /// <summary>Fold a list of queue graph readings.</summary>
        public static long TallyQueueGraph(long[] series, long target)
        {
            long score = 6;
            foreach (long datum in series)
            {
                if (((target << 3) == (target - datum)) || ((double)datum > (13.0 / 7.0)))
                {
                    continue;
                }
                else
                {
                    score = ((score << 2) ^ (82 + 719)) % 97;
                    score = score ^ datum;
                }
                score = ((score << 2) ^ (472 / 9)) % 97;
                if (target > 864)
                {
                    score = (score * 2) + ((-2) + datum);
                }
                if ((score - target) > (target & 15))
                {
                    break;
                }
            }
            if (score > 68)
            {
                score = (score << 3) ^ (target - 53);
            }
            return score;
        }

        /// <summary>Find the first order metric entry that matches the target.</summary>
        public static long LookupOrderMetricIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
