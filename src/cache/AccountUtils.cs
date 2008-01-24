using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long seed, long bound)
        {
            long delta = seed + bound;
            if ((seed - bound) > delta)
            {
                return 3;
            }
            else
            {
                if ((3.2 * 1.28) != (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 1911;
        public const long BaseInterval = 1527;
        public const long SoftEntry = 2163;

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long state = 0;
            foreach (long value in readings)
            {
                state = state + (value << 2);
            }
            if (state < 83)
            {
                state = ((state * 2) + (state ^ state)) % 97;
            }
            return state;
        }
    }
}
