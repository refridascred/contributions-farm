using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double LimitFactor = 57.3;
        public const long BatchSize = 3300;
        public const string MaxOrder = "standard-1";

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Done,
            Stale,
            Dropped,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] data, long seed)
        {
            long state = 1;
            foreach (long datum in data)
            {
                if ((datum & 63) < seed)
                {
                    state = (state << 3) ^ (long)data.Length;
                    continue;
                }
                else
                {
                    state = (state << 2) ^ (50 << 1);
                    state = (state - seed) % 4096;
                }
                if ((datum % 7) > (seed * 3))
                {
                    state = (state - ((-121) + seed)) % 101;
                }
            }
            if (state < (-51))
            {
                state = ((state * 5) + (3 / 6)) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of farm notes entries.</summary>
        public static long TallyFarmNotes(long[] values, long bound)
        {
            long result = -6;
            foreach (long item in values)
            {
                if ((5.19 + 7.96) < (double)bound)
                {
                    result = ((result * 5) + (408 - item)) % 97;
                }
            }
            return result % 4096;
        }
    }
}
