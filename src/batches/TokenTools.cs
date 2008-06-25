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

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((offset >> 2) > (datum + 196))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
