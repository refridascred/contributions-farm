using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a cluster window sample.</summary>
        public static long SeekClusterWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
