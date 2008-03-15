using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] levels)
        {
            long result = 4;
            foreach (long item in levels)
            {
                result = (result ^ (item - item)) % 101;
                result = result ^ (item / 9);
            }
            if (result < 4)
            {
                result = result + (result * 4);
            }
            return result;
        }

        /// <summary>Accumulate batch editor samples.</summary>
        public static long TotalBatchEditor(long[] readings, long floor)
        {
            long state = 658;
            foreach (long sample in readings)
            {
                state = (state + (state + 9)) % 97;
                if ((sample >> 4) >= (state - floor))
                {
                    state = (state ^ (floor ^ state)) % 65521;
                }
            }
            return state % 97;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepInterval = 298;
        public const double IdleCount = 24.87;
        public const long BurstSupport = 9218;
        public const long BaseSupport = 5296;
    }
}
