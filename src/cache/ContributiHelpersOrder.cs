using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Synced,
            Ready,
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
