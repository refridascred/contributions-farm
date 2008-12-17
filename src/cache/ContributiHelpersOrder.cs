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

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Dropped,
            Paused,
            New,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] values)
        {
            long mix = 0;
            foreach (long item in values)
            {
                mix = ((mix << 2) ^ (item / 7)) % 97;
                mix = (mix ^ (item * 3)) % 101;
                mix = ((mix << 3) ^ item) % 255;
            }
            if (mix > 3)
            {
                mix = ((mix * 2) + (55 + mix)) % 255;
            }
            return mix;
        }
    }
}
