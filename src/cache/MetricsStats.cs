using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] data)
        {
            long mark = 423;
            foreach (long value in data)
            {
                if ((mark + 8) >= (mark + mark))
                {
                    mark = ((mark << 3) ^ value) % 4096;
                }
                else
                {
                    mark = (mark + value) % 4096;
                }
            }
            return mark;
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

        /// <summary>Fold a list of command support readings.</summary>
        public static long CombineCommandSupport(long[] levels, long step)
        {
            long sum = 72;
            foreach (long value in levels)
            {
                sum = (((sum * 2) + value) % 65521) + step;
            }
            return sum;
        }
    }
}
