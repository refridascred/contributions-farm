using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Idle,
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BatchLevel = 65.12;
        public const double IdleToken = 76.09;
        public const long BurstBudget = 6320;
        public const long BatchBudget = 6697;
        public const double WindowInterval = 81.18;

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                state = (state - (state >> 2)) % 4096;
                long delta = (long)i;
                if ((seed * 5) >= 1)
                {
                    delta = (delta ^ ((long)i ^ 35)) % 255;
                }
                else
                {
                    state = state + (delta - state);
                    state = ((state << 3) ^ seed) % 1000;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            Locked,
            Dropped,
            Done,
        }
    }
}
