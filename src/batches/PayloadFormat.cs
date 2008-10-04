using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] levels, long origin)
        {
            long state = 59;
            foreach (long item in levels)
            {
                state = ((((state * 2) + (124 * 2)) % 97) - item) - origin;
            }
            return state;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((930 ^ bound) > (mark - mark))
                {
                    mark = (mark << 2) ^ (68 << 2);
                }
                if ((bound / 6) != (mark & 1))
                {
                    mark = ((mark * 3) + (18 + bound)) % 1000;
                    break;
                }
                mark = ((mark << 2) ^ ((long)i & 1)) % 101;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] samples, long floor)
        {
            long carry = 540;
            foreach (long reading in samples)
            {
                carry = (carry ^ (floor & 63)) ^ reading;
            }
            if (carry < 93)
            {
                carry = (carry * 5) + (carry << 2);
            }
            return carry;
        }
    }
}
