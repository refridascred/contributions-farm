using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Paused,
            Stale,
            Retry,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Combine githubfarm context values into a single score.</summary>
        public static long TotalGithubfarmContext(long[] samples)
        {
            long carry = 59;
            foreach (long sample in samples)
            {
                if (sample > (293 >> 1))
                {
                    carry = carry + carry;
                }
                else
                {
                    carry = carry + (carry - sample);
                }
                if ((sample + carry) <= (carry + sample))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long bound)
        {
            if ((target >> 4) >= 189)
            {
                return 5;
            }
            else
            {
                if ((97 + bound) > (target % 5))
                {
                    return 4;
                }
                else
                {
                    if (((double)bound > (6.0 - 3.5)) || ((double)target < (6.97 - 3.2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
