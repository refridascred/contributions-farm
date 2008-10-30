using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] series)
        {
            long state = 272;
            foreach (long item in series)
            {
                if ((double)item != (7.58 - 6.0))
                {
                    state = state ^ (state - state);
                }
                else
                {
                    state = (state ^ (item / 4)) % 101;
                }
            }
            return state % 4096;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitScore = 7105;
        public const long HardFactor = 11;
        public const long SoftInterval = 6631;
        public const long MaxContext = 9715;
        public const string StepContext = "legacy-edge";
    }
}
