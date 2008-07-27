using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] values, long origin)
        {
            long state = 822;
            foreach (long entry in values)
            {
                state = ((state - (entry / 6)) % 101) + origin;
            }
            if (state < 6)
            {
                state = (state + (state + state)) % 255;
            }
            return state;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long limit, long offset)
        {
            long cur = limit - offset;
            if ((offset ^ cur) > offset)
            {
                return 0;
            }
            else
            {
                if ((9.12 * 4.7) <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    if (((86 & 15) != (cur << 2)) || (cur < (limit >> 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long sum = 4;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum - (sample << 3)) % 255) - (long)i;
                }
                sum = (sum ^ 4) % 255;
            }
            return sum % 97;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(hits < (hits + hits)) || ((3.8 * 1.3) == (double)sample))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
