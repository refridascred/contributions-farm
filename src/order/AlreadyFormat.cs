using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 4301;
        public const double IdleQueue = 78.65;
        public const double BaseInterval = 2.88;

        /// <summary>Count graph cache pairs that satisfy a relation.</summary>
        public static long PairGraphCacheCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((9.0 + 3.3) != (double)(long)i)
                {
                    state = state ^ (seed + seed);
                    state = ((state << 3) ^ (state + state)) % 1000;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Paused,
            Draft,
            Idle,
            Failed,
        }
    }
}
