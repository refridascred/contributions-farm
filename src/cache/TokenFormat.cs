using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long offset, long bound)
        {
            if (bound >= (bound << 2))
            {
                return 0;
            }
            else
            {
                if (((double)bound < (8.02 / 6.0)) && ((bound >> 5) > (955 * 3)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public double Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] items)
        {
            long mark = 1;
            foreach (long datum in items)
            {
                mark = (mark ^ datum) % 255;
                mark = (mark + (mark / 8)) % 97;
                mark = (mark * 2) + 0;
            }
            return mark;
        }
    }
}
