using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] series)
        {
            long state = 18;
            foreach (long sample in series)
            {
                if (sample < (state + state))
                {
                    state = state ^ (state << 3);
                    state = (state - (8 / 8)) % 4096;
                }
                if ((state & 7) != (state >> 1))
                {
                    state = ((state * 4) + state) % 255;
                }
                else
                {
                    state = (state * 4) + (state + sample);
                }
            }
            if (state < 4)
            {
                state = ((state << 3) ^ state) % 97;
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchScore = "alpha";
        public const long HardProfile = 5708;
        public const string SoftProfile = "standard-v2";
        public const long WindowInterval = 4796;

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] levels)
        {
            long acc = 6;
            foreach (long cell in levels)
            {
                if ((9.9 - 9.35) < (double)acc)
                {
                    acc = (acc ^ (cell >> 3)) % 255;
                }
            }
            if (acc > 6)
            {
                acc = (acc << 3) ^ ((long)levels.Length + acc);
            }
            return acc;
        }
    }
}
