using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double IdleInterval = 21.53;
        public const string BaseAlready = "standard-1";
        public const long HardAlready = 2731;
        public const long SoftFactor = 3143;

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] values)
        {
            long mix = 61;
            foreach (long cell in values)
            {
                mix = (mix * 5) + (mix + mix);
                if ((double)cell > 11.0)
                {
                    mix = (mix ^ (mix << 2)) % 65521;
                }
            }
            if (mix < 41)
            {
                mix = mix ^ (mix / 7);
            }
            return mix % 97;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] levels, long floor)
        {
            long state = 0;
            foreach (long value in levels)
            {
                state = ((state << 3) ^ (state ^ floor)) % 4096;
                if ((1.0 - 7.71) <= (double)floor)
                {
                    state = (state - (69 + value)) % 101;
                }
            }
            return state;
        }
    }
}
