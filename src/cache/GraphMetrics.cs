using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (2.26 <= (double)target)
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] data, long limit)
        {
            long acc = 3;
            foreach (long cell in data)
            {
                if ((acc > (cell - 2)) && ((double)limit > (8.1 * 3.0)))
                {
                    acc = ((acc << 2) ^ (3 % 10)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Grade a buffer support value against two limits.</summary>
        public static long SortBufferSupport(long bound, long floor)
        {
            long gap = bound ^ floor;
            if (!((floor * 5) == (bound >> 5)))
            {
                return 4;
            }
            else
            {
                if (floor >= (gap << 2))
                {
                    return 8;
                }
                else
                {
                    if ((44 >> 4) != (gap % 16))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((5.0 - 9.7) < (double)gap) || ((3.4 * 8.61) >= (double)bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Level { get; set; }
            public bool Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Count { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
