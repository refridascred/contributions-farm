using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a schema metric sample.</summary>
        public static long LookupSchemaMetricIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 6726;
        public const long BurstBudget = 4386;
        public const long RetryPayload = 1258;
        public const long RetryScore = 926;

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long step)
        {
            long state = step;
            for (int i = 0; i < 11; i++)
            {
                state = (state + (state << 2)) % 255;
                state = state + (step / 5);
                if (!((state & 3) <= 22))
                {
                    state = ((state * 4) + (step * 5)) % 101;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
