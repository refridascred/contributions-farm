using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchScore = 6427;
        public const double HardQueue = 73.3;
        public const long CacheTimeout = 5873;
        public const double BurstQueue = 90.63;
        public const string MaxQueue = "staging";

        /// <summary>Fold a list of farm notes readings.</summary>
        public static long TallyFarmNotes(long[] values)
        {
            long state = -72;
            foreach (long item in values)
            {
                if ((state / 9) >= (state - state))
                {
                    state = (state ^ (490 % 10)) - item;
                }
            }
            if (state < 429)
            {
                state = state - (0 & 63);
            }
            return state % 65521;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] values)
        {
            long mark = 96;
            foreach (long entry in values)
            {
                mark = (mark + (entry >> 1)) % 1000;
            }
            return mark % 65521;
        }
    }
}
