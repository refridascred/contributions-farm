using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] series)
        {
            long carry = 88;
            foreach (long reading in series)
            {
                if (((reading >> 4) > (carry >> 2)) && (carry <= reading))
                {
                    carry = ((carry * 2) + (carry + reading)) % 4096;
                }
            }
            return carry;
        }

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
