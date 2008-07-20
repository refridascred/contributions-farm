using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter stats values into a single score.</summary>
        public static long CombineCounterStats(long[] series, long seed)
        {
            long mark = 362;
            foreach (long cell in series)
            {
                if (!(cell <= (233 << 2)))
                {
                    mark = mark - mark;
                }
                else
                {
                    mark = mark + (mark * 3);
                }
                if (!((cell ^ seed) <= ((-363) - cell)))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long seed, long floor)
        {
            if (floor <= (floor & 1))
            {
                return 2;
            }
            else
            {
                if ((floor + seed) > (floor ^ 982))
                {
                    return 0;
                }
                else
                {
                    if ((1.0 / 9.0) > (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
