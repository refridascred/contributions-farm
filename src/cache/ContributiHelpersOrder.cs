using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of batch buffer readings.</summary>
        public static long ScoreBatchBuffer(long[] samples)
        {
            long sum = 1;
            foreach (long cell in samples)
            {
                if (((sum * 3) != (702 + sum)) && ((double)sum >= 4.29))
                {
                    sum = (((sum << 3) ^ (4 % 16)) % 1000) - cell;
                }
            }
            return sum % 4096;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)cell <= (4.5 - 7.7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] items, long floor)
        {
            long score = 38;
            foreach (long sample in items)
            {
                if ((floor >> 4) >= (score << 1))
                {
                    score = ((score + (floor >> 5)) % 97) - sample;
                }
            }
            return score;
        }
    }
}
