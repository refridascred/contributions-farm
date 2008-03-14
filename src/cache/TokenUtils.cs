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

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (((state << 2) ^ (83 % 3)) % 101) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
