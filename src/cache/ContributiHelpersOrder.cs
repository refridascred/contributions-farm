using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] values, long target)
        {
            long state = -971;
            foreach (long item in values)
            {
                if (state < (364 + state))
                {
                    state = (state - (48 * 2)) % 255;
                }
                state = (state + state) % 255;
                if ((target + target) >= (target - item))
                {
                    state = ((state << 2) ^ (state * 4)) % 255;
                }
                else
                {
                    state = state + item;
                }
            }
            if (state < 352)
            {
                state = (state + (target << 1)) % 97;
            }
            return state;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Paused,
            Dropped,
            Closed,
            Queued,
        }
    }
}
