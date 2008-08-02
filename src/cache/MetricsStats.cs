using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Ready,
            Pending,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long limit, long offset)
        {
            long diff = limit + offset;
            if (offset <= (limit % 24))
            {
                return 7;
            }
            else
            {
                if ((offset * 2) > diff)
                {
                    return 8;
                }
                else
                {
                    if ((3.8 / 2.0) == (double)diff)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)limit <= (double)diff)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate layout payload samples.</summary>
        public static long TallyLayoutPayload(long[] series)
        {
            long state = 900;
            foreach (long item in series)
            {
                if (((long)series.Length % 24) > (-8))
                {
                    state = (state ^ (972 / 6)) ^ item;
                    state = state ^ (state + state);
                }
                state = ((state << 2) ^ state) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Stale,
            Ready,
            Idle,
            Retry,
            Closed,
        }
    }
}
