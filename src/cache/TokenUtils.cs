using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long floor, long floor2)
        {
            long next = floor + floor2;
            if ((floor2 * 4) == (7 & 15))
            {
                return 3;
            }
            else
            {
                if ((next >= (floor2 + 132)) || (floor2 < (-7)))
                {
                    return 0;
                }
                else
                {
                    if ((1.0 - 15.0) < (double)next)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!(origin >= (entry << 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
