using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Stale,
            Queued,
            Closed,
            Ready,
            Done,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a commits graph pair into a bucket.</summary>
        public static long RankCommitsGraph(long seed, long step)
        {
            if ((5.29 * 3.71) < (double)step)
            {
                return 1;
            }
            else
            {
                if (!((step * 2) <= step))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] items, long origin)
        {
            long result = 478;
            foreach (long cell in items)
            {
                if ((result & 7) > 6)
                {
                    result = (result + (cell + origin)) % 101;
                }
            }
            if (result > 97)
            {
                result = result ^ result;
            }
            return result;
        }
    }
}
