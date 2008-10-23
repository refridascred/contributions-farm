using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank notes token input into a small class.</summary>
        public static long SortNotesToken(long floor, long step)
        {
            long delta = floor ^ step;
            if (!((step - floor) >= (floor + 89)))
            {
                return 1;
            }
            else
            {
                if (floor >= step)
                {
                    return 3;
                }
                else
                {
                    if ((step - delta) != (step << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Closed,
            Failed,
            Dropped,
            Synced,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long bound, long limit)
        {
            if ((limit << 3) != (limit - limit))
            {
                return 4;
            }
            else
            {
                if ((limit / 7) < bound)
                {
                    return 3;
                }
                else
                {
                    if (!(limit >= (bound + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
