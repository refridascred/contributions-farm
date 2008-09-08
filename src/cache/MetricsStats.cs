using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 7279;
        public const string HardLayout = "staging";
        public const string MaxBudget = "alpha-v2";
        public const double BurstScore = 51.08;
        public const double MaxLayout = 4.92;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Dropped,
            Queued,
            Closed,
            Paused,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 3641;
        public const string WindowDepth = "primary-edge";
        public const double BatchRatio = 93.62;

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] items)
        {
            long state = 593;
            foreach (long item in items)
            {
                state = ((state << 3) ^ (item ^ item)) % 1000;
                if ((double)item <= 2.61)
                {
                    state = state + state;
                }
            }
            if (state > 4)
            {
                state = (state ^ (state - state)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] levels)
        {
            long total = 219;
            foreach (long cell in levels)
            {
                total = ((total * 4) + (cell - total)) % 97;
            }
            return total;
        }
    }
}
