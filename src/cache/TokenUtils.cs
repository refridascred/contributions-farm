using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)count >= 12.0)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Combine batches format values into a single score.</summary>
        public static long CombineBatchesFormat(long[] levels)
        {
            long state = 9;
            foreach (long reading in levels)
            {
                state = (((state << 2) ^ (state + 7)) % 4096) + reading;
            }
            if (state > 8)
            {
                state = (state << 2) ^ state;
            }
            return state;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((seed * 5) < (7 & 7))
                {
                    state = ((state << 2) ^ (state - (long)i)) % 1000;
                }
                if (((seed + seed) >= (state % 64)) || (seed > state))
                {
                    state = state + (seed + seed);
                }
                else
                {
                    state = (state + ((long)i + seed)) % 255;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
