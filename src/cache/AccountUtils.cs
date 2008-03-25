using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample + tally) != (tally & 63))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] series)
        {
            long state = 7;
            foreach (long value in series)
            {
                if ((state / 8) != (value ^ value))
                {
                    state = ((state * 2) + (value + value)) % 255;
                }
                else
                {
                    state = state ^ (value * 4);
                }
                state = (state + (state % 10)) % 65521;
            }
            if (state < 217)
            {
                state = state ^ (state - state);
            }
            return state;
        }

        /// <summary>Digest a series of context payload entries.</summary>
        public static long ScoreContextPayload(long[] data, long limit)
        {
            long mark = 799;
            foreach (long value in data)
            {
                if ((4.06 + 8.1) < (double)mark)
                {
                    mark = (mark * 4) + (limit >> 1);
                }
                if (((mark + mark) != (value - limit)) || ((mark - mark) >= (value - 97)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
