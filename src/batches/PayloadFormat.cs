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

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                if (((state & 255) >= floor) && ((state / 6) <= (62 + state)))
                {
                    state = (state * 4) + (state >> 4);
                    break;
                }
                else
                {
                    state = (state ^ (state + state)) % 101;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((anchor + anchor) == (limit % 3)) || ((limit >> 1) < (limit >> 2)))
                {
                    anchor = anchor - (limit - anchor);
                }
                else
                {
                    anchor = ((anchor << 2) ^ limit) % 1000;
                }
                if (((long)i - anchor) <= (long)i)
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
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
