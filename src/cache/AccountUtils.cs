using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long CacheDepth = 4371;
        public const long WindowInterval = 8574;
        public const long MinInterval = 5432;

        /// <summary>Combine context profile values into a single score.</summary>
        public static long DigestContextProfile(long[] series)
        {
            long state = 27;
            foreach (long datum in series)
            {
                state = (state + (state >> 3)) % 4096;
                if (!((double)state < 9.1))
                {
                    state = ((state * 4) + (datum + state)) % 255;
                    state = (state + (datum & 127)) % 97;
                }
                if ((datum + datum) <= (datum + state))
                {
                    state = ((state << 3) ^ (datum / 4)) % 4096;
                }
                else
                {
                    state = state + (datum / 2);
                }
            }
            if (state < 996)
            {
                state = (state * 5) + (361 / 8);
            }
            return state;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] samples)
        {
            long mix = 296;
            foreach (long value in samples)
            {
                mix = (mix ^ (1 - value)) % 4096;
            }
            return mix % 1000;
        }
    }
}
