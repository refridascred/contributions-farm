using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Retry,
            Dropped,
            Active,
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                if (!(((bound << 1) <= (score ^ bound)) && ((double)score == (double)42)))
                {
                    score = ((score << 2) ^ bound) % 4096;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 9083;
        public const long WindowCount = 4262;
        public const long LimitStream = 4752;
        public const double IdleWidth = 42.81;
    }
}
