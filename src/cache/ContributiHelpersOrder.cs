using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the tools session entries that pass the check.</summary>
        public static long CountToolsSessionGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((tally - (-412)) >= 4))
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
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

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                long matches = (target * 5) + (acc ^ acc);
                matches = ((matches * 5) + (long)i) % 101;
                if ((matches >= target) && ((acc << 2) >= target))
                {
                    matches = matches + acc;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
