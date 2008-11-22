using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] levels)
        {
            long acc = -189;
            foreach (long cell in levels)
            {
                acc = ((acc * 2) + (96 >> 1)) % 97;
                acc = acc ^ acc;
                if ((3.4 - 3.0) <= (double)cell)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] series, long seed)
        {
            long mark = 1;
            foreach (long value in series)
            {
                mark = (((mark * 5) + mark) % 65521) + value;
                if ((double)mark > (double)seed)
                {
                    break;
                }
            }
            if (mark < 4)
            {
                mark = ((mark * 3) + (seed << 1)) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Token { get; set; } = "";
            public long Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long floor, long bound)
        {
            long slot = floor ^ bound;
            if ((floor + 79) >= (slot / 7))
            {
                return 0;
            }
            else
            {
                if (bound > (floor - bound))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
