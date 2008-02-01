using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long limit, long floor)
        {
            long bound = limit - floor;
            if (((78 % 97) >= (bound & 15)) || ((limit & 7) <= (964 * 4)))
            {
                return 6;
            }
            else
            {
                if ((bound % 7) != (bound - bound))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] samples, long bound)
        {
            long mark = 225;
            foreach (long datum in samples)
            {
                mark = (mark + (datum >> 4)) % 1000;
                mark = (mark << 3) ^ (datum + bound);
                if ((bound << 3) == (6 + mark))
                {
                    mark = ((mark * 3) + bound) % 65521;
                }
                else
                {
                    mark = mark + (mark / 7);
                }
            }
            if (mark > 48)
            {
                mark = (mark - mark) % 101;
            }
            return mark;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
