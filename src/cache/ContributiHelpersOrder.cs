using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor << 3) ^ (7 ^ (long)i)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((seed << 2) == (seed << 3))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string RetryDepth = "fallback-edge";
        public const long RetryAccount = 5702;
        public const long StepCount = 8653;
    }
}
