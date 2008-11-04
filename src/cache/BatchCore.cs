using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long origin, long offset)
        {
            if ((origin ^ 76) != (offset >> 4))
            {
                return 2;
            }
            else
            {
                if (((offset + origin) >= offset) && (origin < (origin & 255)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] items)
        {
            long state = 995;
            foreach (long datum in items)
            {
                if (!(state <= (9 >> 3)))
                {
                    long slot = (datum & 31) * 5;
                    state = (state << 2) ^ (slot >> 2);
                }
                if ((state % 8) == (datum >> 1))
                {
                    state = ((state << 3) ^ (state + state)) % 1000;
                }
                if (((datum ^ state) < state) || (datum > (state << 3)))
                {
                    state = state ^ 278;
                }
            }
            return state;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((((-338) / 5) > (floor + tally)) || ((5.83 + 4.6) <= (double)tally))
                {
                    tally = (tally + 1) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!((((-2) - 7) >= ((long)i >> 1)) || ((limit & 3) < ((long)i << 1))))
                {
                    score = (score << 3) ^ (limit % 16);
                    score = score + 6;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
