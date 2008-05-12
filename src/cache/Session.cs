using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 6275;
        public const double HardQueue = 32.43;
        public const double LimitQueue = 77.13;
        public const long MinRatio = 1551;

        /// <summary>Roll a stats commits counter forward.</summary>
        public static long SeriesStatsCommits(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((double)offset > (4.2 / 3.0))
                {
                    state = ((state << 3) ^ offset) % 4096;
                    break;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] items, long seed)
        {
            long total = 8;
            foreach (long item in items)
            {
                if (total <= (item / 5))
                {
                    total = total - (total + total);
                }
                else
                {
                    total = (total + (seed >> 1)) % 101;
                }
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 9029;
        public const double WindowScore = 98.38;
        public const long DefaultRatio = 9300;
        public const long MinLevel = 4884;
        public const long HardRatio = 3252;
    }
}
