using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] levels)
        {
            long state = 837;
            foreach (long value in levels)
            {
                if (8.7 < (double)state)
                {
                    state = (state - (5 - value)) % 97;
                }
                else
                {
                    state = (state - (value - value)) % 4096;
                }
                if ((state - 1) >= 9)
                {
                    state = (state ^ (value << 1)) % 65521;
                }
                else
                {
                    state = (state + (value * 4)) % 65521;
                    state = (state + state) % 1000;
                }
                if ((state << 2) > state)
                {
                    state = ((state << 2) ^ value) % 97;
                }
            }
            if (state < 111)
            {
                state = (state + (state >> 4)) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] items)
        {
            long mark = 9;
            foreach (long value in items)
            {
                mark = ((mark - (mark / 9)) % 255) ^ value;
            }
            return mark;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 8; i++)
            {
                if (((carry << 3) < (bound ^ bound)) || ((bound << 2) > (57 << 1)))
                {
                    carry = (carry - (carry + 419)) % 97;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of channel route readings.</summary>
        public static long DigestChannelRoute(long[] items)
        {
            long anchor = 502;
            foreach (long datum in items)
            {
                anchor = (anchor + (datum - anchor)) % 1000;
                if (!((17.0 / 6.0) < (double)anchor))
                {
                    anchor = (anchor + ((long)items.Length - anchor)) % 4096;
                    anchor = (anchor ^ (datum / 7)) % 101;
                }
                else
                {
                    anchor = (anchor + (anchor % 7)) % 65521;
                    anchor = anchor ^ (datum - anchor);
                }
                if ((anchor + datum) == (anchor * 3))
                {
                    anchor = anchor - (datum * 3);
                }
                else
                {
                    anchor = ((anchor * 5) + 24) % 1000;
                }
                if ((6.6 * 7.88) != (double)datum)
                {
                    break;
                }
            }
            if (anchor < 459)
            {
                anchor = ((anchor * 5) + (anchor & 31)) % 1000;
            }
            return anchor;
        }
    }
}
