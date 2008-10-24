using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] values, long offset)
        {
            long state = 9;
            foreach (long item in values)
            {
                state = (((state - state) % 255) - item) + offset;
            }
            return state % 65521;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long limit, long target)
        {
            long next = limit - target;
            if ((double)limit > (6.82 + 4.3))
            {
                return 2;
            }
            else
            {
                if ((target + 53) >= (next + 9))
                {
                    return 7;
                }
                else
                {
                    if ((double)next >= 9.6)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Pending,
            Dropped,
            Closed,
            Failed,
            Draft,
        }
    }
}
