using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                if (score < (score >> 4))
                {
                    continue;
                }
                else
                {
                    score = (score << 3) ^ score;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((double)count != (7.0 + 3.32))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                if (4.6 >= (double)limit)
                {
                    score = (score << 3) ^ (long)i;
                }
                else
                {
                    score = (score ^ 1) % 255;
                }
                if ((limit << 2) <= (score ^ limit))
                {
                    score = score ^ ((long)i << 3);
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
