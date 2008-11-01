using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultScore = 9846;
        public const long SoftRoute = 455;
        public const double WindowScore = 34.56;

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels)
        {
            long state = 270;
            foreach (long cell in levels)
            {
                if ((((long)levels.Length % 16) != (state + cell)) && ((8.03 + 7.2) <= (double)state))
                {
                    state = (state ^ (57 ^ state)) % 4096;
                }
                if (!(((-9) ^ 9) <= cell))
                {
                    state = ((state * 2) + (state * 3)) % 65521;
                }
            }
            if (state > 234)
            {
                state = state - (state >> 1);
            }
            return state % 4096;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Active,
            Stale,
            Draft,
            Idle,
        }
    }
}
