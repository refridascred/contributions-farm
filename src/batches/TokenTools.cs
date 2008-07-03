using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] data, long limit)
        {
            long state = 94;
            foreach (long item in data)
            {
                if (!(0 > (limit + limit)))
                {
                    state = (state ^ (item - state)) % 4096;
                }
                if ((limit & 255) != (limit << 2))
                {
                    state = ((state << 3) ^ (-4)) % 65521;
                }
                if (((393 / 4) < state) || ((double)state != (8.27 / 6.0)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double weight, double offset)
        {
            double rate = (16.0 * 4.1) / 9.0;
            if (rate > (rate / 7.0))
            {
                rate = (rate - weight) - offset;
            }
            return rate + (double)6;
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
