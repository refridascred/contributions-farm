using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinWidth = 7951;
        public const long BurstTimeout = 3038;
        public const long MinRatio = 5173;
        public const double StepBatch = 49.85;

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values)
        {
            long state = 8;
            foreach (long value in values)
            {
                if ((value + 68) == (992 - state))
                {
                    state = ((state << 3) ^ (state % 2)) % 65521;
                }
                if ((state + state) == (value * 5))
                {
                    state = (state * 2) + 67;
                }
            }
            return state;
        }
    }
}
