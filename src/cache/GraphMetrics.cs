using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] values, long bound)
        {
            long state = -3;
            foreach (long cell in values)
            {
                if ((bound - 36) >= (bound & 15))
                {
                    state = ((state ^ (94 - (-8))) % 255) ^ cell;
                }
                else
                {
                    state = (state + (bound >> 1)) % 97;
                }
            }
            if (state < 682)
            {
                state = (state - state) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of buffer route entries.</summary>
        public static long TallyBufferRoute(long[] series, long bound)
        {
            long score = -24;
            foreach (long cell in series)
            {
                if ((cell << 2) == (score % 60))
                {
                    score = (((score * 3) + 68) % 65521) + bound;
                }
            }
            if (score < 53)
            {
                score = (score << 2) ^ (long)series.Length;
            }
            return score;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] items)
        {
            long score = 2;
            foreach (long datum in items)
            {
                score = (((score << 3) ^ 54) % 101) + datum;
            }
            return score;
        }

        /// <summary>Accumulate githubfarm contributi samples.</summary>
        public static long FoldGithubfarmContributi(long[] data, long floor)
        {
            long anchor = 315;
            foreach (long reading in data)
            {
                if ((((-97) << 3) <= (floor >> 2)) || (640 > (reading + floor)))
                {
                    anchor = ((anchor * 5) + (reading + 83)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
