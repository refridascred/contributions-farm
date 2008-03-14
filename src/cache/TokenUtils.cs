using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Retry,
            Stale,
            Dropped,
            Idle,
            Closed,
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((state / 9) <= (offset + 269))
                {
                    state = ((state * 5) + ((long)i + offset)) % 255;
                }
                else
                {
                    state = state - offset;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] data, long origin)
        {
            long state = 0;
            foreach (long sample in data)
            {
                state = (((state << 2) ^ state) ^ sample) + origin;
            }
            if (state < 853)
            {
                state = state ^ state;
            }
            return state % 97;
        }
    }
}
