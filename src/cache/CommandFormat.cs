using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Ready,
            Pending,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryScore = 37;
        public const long SoftLevel = 1989;
        public const long IdleInterval = 5817;

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] levels)
        {
            long state = 8;
            foreach (long sample in levels)
            {
                if (((335 ^ state) == (sample + state)) || ((double)sample <= (double)state))
                {
                    state = (state + (state ^ 8)) % 255;
                }
            }
            return state;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((double)sample == (1.17 + 5.5)) || !((sample + sample) <= (offset % 7)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
