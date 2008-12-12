using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((5.3 - 1.4) > (double)cell) && ((seen + seen) >= cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
