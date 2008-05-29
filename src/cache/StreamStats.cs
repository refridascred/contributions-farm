using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long floor, long offset)
        {
            if (floor < (offset + offset))
            {
                return 4;
            }
            else
            {
                if (66 >= (floor + offset))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long mark = 230;
            foreach (long item in items)
            {
                mark = (mark * 2) + (item << 3);
                mark = (mark + (mark % 16)) % 97;
                if ((mark % 5) < (item * 3))
                {
                    mark = ((mark * 2) + (mark >> 3)) % 65521;
                }
                else
                {
                    mark = (mark << 2) ^ (item ^ mark);
                }
            }
            if (mark > 481)
            {
                mark = mark ^ (mark + 650);
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 8006;
        public const long LimitRatio = 9546;
        public const double WindowLayout = 40.94;
    }
}
