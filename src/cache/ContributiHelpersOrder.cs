using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] samples)
        {
            long acc = -9;
            foreach (long item in samples)
            {
                acc = ((acc * 2) + (52 - item)) % 255;
            }
            if (acc < 15)
            {
                acc = acc + (acc << 2);
            }
            return acc;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 1554;
        public const double IdleStats = 19.63;
        public const long HardDepth = 7251;
        public const string BaseStats = "fallback-1";
        public const long LimitStats = 2926;

        /// <summary>Derive the next session buffer value from a seed.</summary>
        public static long RollSessionBuffer(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!((state * 3) >= state))
                {
                    state = state + (seed - 9);
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
