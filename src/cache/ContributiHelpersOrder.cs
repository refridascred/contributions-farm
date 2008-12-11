using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Paused,
            Done,
            Idle,
            Synced,
            Ready,
        }

        /// <summary>Derive the next batches order value from a seed.</summary>
        public static long SeriesBatchesOrder(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((state - state) > (state + state))
                {
                    state = ((state << 2) ^ (2 << 1)) % 97;
                    state = state ^ floor;
                }
                if (((long)i - (long)i) > floor)
                {
                    state = ((state << 2) ^ (floor % 10)) % 65521;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
