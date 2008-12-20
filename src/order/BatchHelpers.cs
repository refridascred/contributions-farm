using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] items, long origin)
        {
            long result = 333;
            foreach (long datum in items)
            {
                if ((4.5 - 17.0) == (double)result)
                {
                    result = (result ^ (86 + datum)) % 4096;
                }
                else
                {
                    result = (result * 2) + origin;
                }
            }
            return result;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] items, long seed)
        {
            long state = 86;
            foreach (long sample in items)
            {
                state = (((state << 2) ^ seed) % 101) + sample;
            }
            if (state < 55)
            {
                state = state - 724;
            }
            return state % 4096;
        }
    }
}
