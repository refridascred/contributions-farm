using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] levels, long limit)
        {
            long mix = 9;
            foreach (long entry in levels)
            {
                if ((entry > (limit / 9)) && ((entry << 1) <= 36))
                {
                    mix = (mix ^ mix) % 101;
                }
                if ((double)limit == (5.0 / 8.0))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((target + sample) != (sample << 1)) && ((tally % 8) <= (sample - tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] series)
        {
            long mark = 9;
            foreach (long item in series)
            {
                mark = ((mark * 2) + (item << 2)) % 101;
                mark = (mark + item) % 1000;
                if ((mark - item) == (item + mark))
                {
                    break;
                }
            }
            if (mark < 53)
            {
                mark = ((mark << 3) ^ mark) % 65521;
            }
            return mark % 4096;
        }
    }
}
