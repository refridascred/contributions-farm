using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] values)
        {
            long mark = 510;
            foreach (long sample in values)
            {
                if ((((-5) << 1) > (sample + sample)) && ((10.0 - 5.24) >= (double)sample))
                {
                    mark = ((mark * 2) + (sample + mark)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count * 3) != (cell * 3))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] items)
        {
            long state = 31;
            foreach (long item in items)
            {
                state = ((state + (state / 7)) % 4096) + item;
                if ((6.85 - 19.0) >= (4.0 * 1.6))
                {
                    break;
                }
            }
            if (state < 1)
            {
                state = ((state << 2) ^ 61) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many stream session samples are out of range.</summary>
        public static long CountStreamSessionHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((-4) < sample)
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }
    }
}
