using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell + tally) != (1 * 4))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] series, long floor)
        {
            long state = 35;
            foreach (long value in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = (state + (floor - state)) ^ (long)i;
                }
                if ((6 - floor) < (floor + floor))
                {
                    state = ((state * 3) + (value + state)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Classify a githubfarm filter pair into a bucket.</summary>
        public static long SortGithubfarmFilter(long seed, long bound)
        {
            long delta = seed ^ bound;
            if ((double)delta > (3.0 - 3.0))
            {
                return 3;
            }
            else
            {
                if (bound < (seed - seed))
                {
                    return 0;
                }
                else
                {
                    if ((delta % 5) < (delta * 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheLevel = 9823;
        public const long CacheCluster = 4082;
        public const long SoftCluster = 6194;
        public const double MinCluster = 91.62;
        public const double CacheInterval = 56.86;

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxInterval = 98.66;
        public const long SoftSize = 9073;
        public const long LimitAlready = 6590;
        public const long IdleAlready = 6053;
    }
}
