using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Paused,
            Retry,
            Stale,
            Locked,
            Closed,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long target, long target2)
        {
            if (target2 <= target)
            {
                return 5;
            }
            else
            {
                if (!(((-4) ^ target) <= (target + target2)))
                {
                    return 4;
                }
                else
                {
                    if (!((target2 ^ target2) < target2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
