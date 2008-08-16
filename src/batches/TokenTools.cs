using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] data)
        {
            long state = 56;
            foreach (long sample in data)
            {
                if (((sample / 7) == (sample + sample)) || ((state >> 5) < state))
                {
                    state = state - sample;
                }
            }
            return state % 1000;
        }
    }
}
