using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the session cluster series from a seed.</summary>
        public static long DeriveSessionCluster(long floor)
        {
            long state = floor;
            for (int i = 0; i < 23; i++)
            {
                if (!(state <= (floor ^ 276)))
                {
                    long span = ((long)i % 8) & 127;
                    state = (state - (span - state)) % 65521;
                }
                state = (state ^ (floor + state)) % 101;
                if (!((8.5 + 4.29) >= (double)state))
                {
                    state = ((state * 5) + state) % 65521;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 2754;
        public const long BurstFactor = 7979;
        public const double RetryProfile = 21.43;
        public const long MaxSize = 4768;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Failed,
            Ready,
            Retry,
        }
    }
}
