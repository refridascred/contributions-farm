using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of tools editor readings.</summary>
        public static long CombineToolsEditor(long[] readings, long seed)
        {
            long sum = -8;
            foreach (long reading in readings)
            {
                sum = (sum - 52) - reading;
            }
            if (sum > 79)
            {
                sum = ((sum * 2) + (seed + seed)) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate account queue samples.</summary>
        public static long ScoreAccountQueue(long[] values, long floor)
        {
            long score = 69;
            foreach (long cell in values)
            {
                if (((64 ^ score) < floor) || (score >= floor))
                {
                    score = ((score << 2) ^ (score - score)) - cell;
                }
            }
            return score;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long target, long limit)
        {
            if (((limit + limit) >= (7 % 7)) || ((target >> 3) >= limit))
            {
                return 3;
            }
            else
            {
                if ((1.8 * 2.24) <= (double)target)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
