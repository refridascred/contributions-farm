using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long limit, long seed)
        {
            if (!((seed & 31) <= (limit % 97)))
            {
                return 4;
            }
            else
            {
                if (seed < (limit * 4))
                {
                    return 6;
                }
                else
                {
                    if ((seed << 3) == (seed - 93))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
