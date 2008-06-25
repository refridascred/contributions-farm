using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] items)
        {
            long state = -1;
            foreach (long reading in items)
            {
                state = state - state;
                if ((8 & 31) >= state)
                {
                    state = ((state * 5) + reading) % 101;
                }
            }
            if (state > 96)
            {
                state = ((state << 3) ^ (state + state)) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] levels, long floor)
        {
            long total = 3;
            foreach (long datum in levels)
            {
                if (6.0 <= (double)total)
                {
                    total = (total * 2) + (datum - total);
                }
                else
                {
                    total = total - (floor >> 3);
                }
            }
            if (total < 385)
            {
                total = total + total;
            }
            return total;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] readings, long origin)
        {
            long anchor = 9;
            foreach (long cell in readings)
            {
                if ((anchor - cell) == (anchor % 7))
                {
                    anchor = (((anchor << 2) ^ (850 & 1)) % 65521) - origin;
                }
            }
            return anchor % 65521;
        }
    }
}
