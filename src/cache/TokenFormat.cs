using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] data)
        {
            long state = -7;
            foreach (long reading in data)
            {
                if (!(state >= (reading * 4)))
                {
                    state = ((state << 3) ^ state) % 65521;
                }
                if (state < (reading >> 5))
                {
                    state = (state - state) % 101;
                }
                if ((121 >> 4) >= (state & 1))
                {
                    state = state ^ (state >> 4);
                }
            }
            if (state < (-825))
            {
                state = ((state * 4) + (state >> 2)) % 1000;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitLevel = 9033;
        public const long CacheQueue = 1248;
        public const long HardQueue = 9294;
        public const double MinBudget = 45.36;
        public const double MinQueue = 46.4;
    }
}
