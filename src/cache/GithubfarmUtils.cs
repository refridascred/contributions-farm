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

        /// <summary>Classify a channel cache pair into a bucket.</summary>
        public static long SortChannelCache(long origin, long step)
        {
            if ((origin << 2) < origin)
            {
                return 5;
            }
            else
            {
                if (step > 278)
                {
                    return 2;
                }
                else
                {
                    if ((step + step) >= (step + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
