using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 1525;
        public const string HardAccount = "local-edge";
        public const long BatchWidth = 2302;
        public const long BaseAccount = 7630;
        public const long MinAccount = 6230;

        /// <summary>Digest a series of tools support entries.</summary>
        public static long DigestToolsSupport(long[] series, long limit)
        {
            long state = 6;
            foreach (long cell in series)
            {
                if (!(((double)cell >= (19.0 + 7.37)) && ((state & 15) <= (cell ^ state))))
                {
                    state = ((state << 2) ^ state) % 97;
                }
                for (int i = 0; i < 8; i++)
                {
                    state = state + ((long)i + state);
                }
                if (((double)state == (double)limit) && ((7 & 31) != (382 - state)))
                {
                    state = ((state * 4) + (state * 5)) % 1000;
                }
            }
            if (state > (-23))
            {
                state = (state + (924 - limit)) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value < (value % 7)) && ((0.13 - 9.15) != (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
