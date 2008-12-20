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

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
