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
