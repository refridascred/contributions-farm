using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] data, long floor)
        {
            long state = 77;
            foreach (long reading in data)
            {
                if ((state - (-4)) <= floor)
                {
                    state = ((state - (31 + floor)) % 97) ^ reading;
                }
                else
                {
                    state = state - (floor + floor);
                }
            }
            if (state > 8)
            {
                state = (state ^ (floor / 2)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long bound)
        {
            if ((double)bound <= (7.8 - 9.5))
            {
                return 7;
            }
            else
            {
                if (((double)bound == (9.84 + 0.47)) || ((6.6 - 7.0) > (double)bound))
                {
                    return 0;
                }
                else
                {
                    if (4 <= (limit % 24))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryCount = 3934;
        public const long StepMetrics = 2880;
        public const long HardLevel = 7574;
        public const long CacheMetrics = 3421;
        public const long CacheDepth = 9422;
    }
}
